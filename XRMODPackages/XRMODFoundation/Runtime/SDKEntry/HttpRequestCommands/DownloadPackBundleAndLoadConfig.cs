// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.SDKEntry.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Networking;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    public class DownloadPackBundleAndLoadConfig : IHttpRequestCommand<string>
    {
        private readonly QueryParameter queryParameter;

        public DownloadPackBundleAndLoadConfig(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<string> Execute()
        {
            try
            {
                string tmp_Url = new Uri($"{queryParameter.AssetBundleContentUrl}").ToString();
                string tmp_FileNameWithExtension = Path.GetFileName(tmp_Url).ToLower().Split("?").FirstOrDefault();
                string tmp_FileNameWithoutExtension =
                    Path.GetFileNameWithoutExtension(tmp_Url).ToLower().Split("?").FirstOrDefault();
                string tmp_DestinationPath = Application.isEditor
                    ? $"ServerData/{RuntimePlatformHelper.GetPlatformName().ToLower()}/{tmp_FileNameWithoutExtension}"
                    : $"{Application.temporaryCachePath}/{tmp_FileNameWithoutExtension}";

                var tmp_PackFilePath = Path.Combine(tmp_DestinationPath, $"{tmp_FileNameWithoutExtension}.package");
                var tmp_ExperienceFilePath =
                    Path.Combine(tmp_DestinationPath, $"{tmp_FileNameWithoutExtension}.arexperience");
                var tmp_SceneExperienceFilePath =
                    Path.Combine(tmp_DestinationPath, $"{tmp_FileNameWithoutExtension}_Scene.arexperience");

                bool tmp_ExperienceFileExists = File.Exists(tmp_ExperienceFilePath);
                bool tmp_SceneFileExists = File.Exists(tmp_SceneExperienceFilePath);

                if (!Utility.XRExperienceInCache(queryParameter.experienceUid, queryParameter.Crc.ToString(),
                        queryParameter.Hash))
                {
                    if (!tmp_Url.Contains("file:///"))
                    {
                        if (!Directory.Exists(tmp_DestinationPath))
                            Directory.CreateDirectory(tmp_DestinationPath);

                        var tmp_PackDownloader = new UnityWebRequest(tmp_Url, UnityWebRequest.kHttpVerbGET);
                        tmp_PackDownloader.downloadHandler = new DownloadHandlerFile(tmp_PackFilePath);
                        tmp_PackDownloader.timeout = queryParameter.Timeout;
                        var tmp_Progress = Progress.Create<float>(APICallback.ExperienceLoading);
                        await tmp_PackDownloader.SendWebRequest().ToUniTask(tmp_Progress);
                    }

                    if (tmp_ExperienceFileExists)
                        File.Delete(tmp_ExperienceFilePath);

                    if (tmp_SceneFileExists)
                        File.Delete(tmp_SceneExperienceFilePath);

                    if (!File.Exists(tmp_ExperienceFilePath) && File.Exists(tmp_PackFilePath))
                    {
                        // Unzip the file
                        ZipFileUtility.UnzipFiles(tmp_PackFilePath, tmp_DestinationPath,
                            ZipFileUtility.CalculateStringMD5(tmp_FileNameWithoutExtension));
                        File.Delete(tmp_PackFilePath);
                    }
                }

                // Load Config to start XR-Experience
                var tmp_PropertyText = await BasePackageLoaderUtility.LoadBundleFromLocal<TextAsset>(
                    Path.Combine(tmp_DestinationPath, $"{tmp_FileNameWithoutExtension}.arexperience"),
                    ConstKey.CONST_CONFIGURES,
                    _progress =>
                    {
                        APICallback.ExperienceLoading(_progress);
                        if (_progress >= 1)
                            APICallback.ExperienceLoadCompleted();
                    }, Debug.LogError);
                return tmp_PropertyText.text;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                APICallback.ThrowException(nameof(ErrorCode.UNPACKING_FAILED), (int) ErrorCode.UNPACKING_FAILED);
                throw;
            }
        }
    }
}