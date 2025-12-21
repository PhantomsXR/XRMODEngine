using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    public interface IRequestCommandCreator
    {
        Task<object> Create(QueryParameter _param, SDKConfiguration _config);
    }

    public enum NetworkRequestType
    {
        InfoByUId,
        InfoByMarker,
        DownloadAssetBundleJson,
        DownloadAssetBundleContent,
        LoadConfigure,
        GetExperienceAssets
    }

    public class NetworkRequestFactory<T> : SingletonTemplate<NetworkRequestFactory<T>> where T : class, new()
    {
        private static readonly Dictionary<NetworkRequestType, Func<QueryParameter, SDKConfiguration, Task<object>>>
            _REGISTRY = new();

        static NetworkRequestFactory()
        {
            RegisterCommands();
        }

        private static void RegisterCommands()
        {
            _REGISTRY.Add(NetworkRequestType.InfoByUId, async (_param, _config) =>
            {
                switch (_config.AppModel)
                {
                    case AppModel.Online when _param.BackendType == BackendType.Legacy:
                        return await new QueryXRProjectForOnlineLegacy<T>(_param).Execute();
                    case AppModel.Online when _param.BackendType == BackendType.Supabase:
                        return await new QueryXRProjectForOnlineSupabase(_param).Execute();
                    case AppModel.Offline:
                        return await new QueryARProjectForOffline(_param).Execute();
                    case AppModel.Simulator:
                        return await new QueryARProjectForSimulator(_param).Execute();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });

            _REGISTRY.Add(NetworkRequestType.DownloadAssetBundleJson, async (_param, _config) =>
            {
                var tmp_JsonUrl = _config.AppModel is AppModel.Online
                    ? _param.AssetBundleJsonUrl
                    : Application.platform == RuntimePlatform.Android
                        ? _param.AssetBundleJsonUrl
                        : $"file://{_param.AssetBundleJsonUrl}";
                _param.AssetBundleJsonUrl = tmp_JsonUrl;
                return await new DownloadAssetBundleJson<T>(_param).Execute();
            });

            _REGISTRY.Add(NetworkRequestType.DownloadAssetBundleContent,
                async (_param, _config) => await new DownloadAssetBundleContent(_param).Execute());

            _REGISTRY.Add(NetworkRequestType.LoadConfigure,
                async (_param, _config) => await new GetPackageConfigure(_param).Execute());
        }

        public static async Task<T> CreateNetworkRequest(NetworkRequestType _networkRequestType,
            QueryParameter _param)
        {
            if (!_REGISTRY.TryGetValue(_networkRequestType, out var tmp_Creator))
            {
                throw new ArgumentOutOfRangeException(nameof(_networkRequestType), _networkRequestType, null);
            }

            var tmp_SDKConfiguration = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value;
            var tmp_Result = await tmp_Creator(_param, tmp_SDKConfiguration);
            return tmp_Result as T;
        }
    }
}