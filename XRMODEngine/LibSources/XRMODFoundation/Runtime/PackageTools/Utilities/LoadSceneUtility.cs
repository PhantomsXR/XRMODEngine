// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    public class LoadSceneUtility
    {
        public static async Task LoadSceneAsync(AssetBundle _assetBundle, string _sceneName)
        {
            var tmp_ScenePaths = _assetBundle.GetAllScenePaths();
            var tmp_WannaScenePath =
                tmp_ScenePaths.FirstOrDefault(_scenePath => _scenePath.Contains(_sceneName));
            if (string.IsNullOrEmpty(tmp_WannaScenePath))
                throw new Exception($"Load {_sceneName} scene failed.");
            string tmp_SceneName = Path.GetFileNameWithoutExtension(tmp_WannaScenePath);
            await SceneManager.LoadSceneAsync(tmp_SceneName, LoadSceneMode.Additive).ToUniTask();
        }

        public static async Task UnLoadSceneAsync(AssetBundle _assetBundle, string _sceneName)
        {
            var tmp_ScenePaths = _assetBundle.GetAllScenePaths();
            var tmp_WannaScenePath =
                tmp_ScenePaths.FirstOrDefault(_scenePath => _scenePath.Contains(_sceneName));
            if (string.IsNullOrEmpty(tmp_WannaScenePath))
                throw new Exception($"{_sceneName} scene not exist.");
            string tmp_SceneName = Path.GetFileNameWithoutExtension(tmp_WannaScenePath);
            await SceneManager.UnloadSceneAsync(tmp_SceneName).ToUniTask();
        }

        public static async void UnloadRuntimeScenes(AssetBundle _assetBundle)
        {
            try
            {
                var tmp_ScenePaths = _assetBundle.GetAllScenePaths();
                foreach (var tmp_ScenePath in tmp_ScenePaths)
                {
                    var tmp_SceneName = Path.GetFileNameWithoutExtension(tmp_ScenePath);
                    var tmp_Scene = SceneManager.GetSceneByName(tmp_SceneName);
                    if (tmp_Scene.isLoaded && tmp_Scene.IsValid())
                    {
                        await SceneManager.UnloadSceneAsync(tmp_SceneName).ToUniTask();
                    }
                }
            }
            catch (Exception e)
            {
                throw; // TODO handle exception
            }
        }
    }
}