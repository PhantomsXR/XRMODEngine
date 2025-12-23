// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.Models;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using Phantom.XRMOD.XRMODUtilites.Runtime;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    /// <summary>
    /// High-level command that determines the correct strategy for loading an experience configuration
    /// based on the package mode (Asset only vs Asset and Scene).
    /// </summary>
    public class GetPackageConfigure : IHttpRequestCommand<TextAsset>
    {
        private QueryParameter queryParameter;

        public GetPackageConfigure(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<TextAsset> Execute()
        {
            try
            {
                TextAsset tmp_PropertyText = null;
                var tmp_SDKEntryPointModel = IocContainer.GetIoc.Resolve<SDKEntryPointModel>();
                if (tmp_SDKEntryPointModel.XRExperienceData.PackMode == XRExperienceData.PackModeType.AssetAndScene)
                {
                    var tmp_ConfigText = await new DownloadPackBundleAndLoadConfig(queryParameter).Execute();
                    tmp_PropertyText = new TextAsset(tmp_ConfigText);
                }
                else
                {
                    tmp_PropertyText = await BasePackageLoaderUtility.LoadBundleFromUrl<TextAsset>(
                        _uri: new Uri(queryParameter.AssetBundleContentUrl),
                        _timeout: queryParameter.Timeout,
                        _wannaLoadAssetsName: ConstKey.CONST_CONFIGURES,
                        _hash128: Hash128.Parse(queryParameter.Hash),
                        _crc: queryParameter.Crc,
                        _failedAction: Debug.LogError,
                        _progressAction: (_progress) =>
                        {
                            APICallback.ExperienceLoading(_progress);
                            //Dismiss loading overlay UI
                            if (_progress >= 1)
                                APICallback.ExperienceLoadCompleted();
                        }
                    );

                    Assert.IsNotNull(tmp_PropertyText, "tmp_PropertyText != null");

                    if (string.IsNullOrEmpty(tmp_PropertyText.text))
                    {
                        throw new NullReferenceException("XRProperties file is empty!");
                    }
                }

                return tmp_PropertyText;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                APICallback.ThrowException(nameof(ErrorCode.UNPACKING_FAILED), (int) ErrorCode.UNPACKING_FAILED);
            }

            return null;
        }
    }
}