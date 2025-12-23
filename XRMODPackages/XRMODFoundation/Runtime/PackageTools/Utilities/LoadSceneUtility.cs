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
    /// <summary>
    /// Utility class for loading and unloading Unity scenes from Asset Bundles.
    /// Uses UniTask for asynchronous operations.
    /// </summary>
    public class LoadSceneUtility
    {
        /// <summary>
        /// Asynchronously loads a scene from an Asset Bundle additively.
        /// </summary>
        /// <param name="_assetBundle">The bundle containing the scene.</param>
        /// <param name="_sceneName">The name of the scene to load.</param>
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

        /// <summary>
        /// Asynchronously unloads a specific scene that was loaded from an Asset Bundle.
        /// </summary>
        /// <param name="_assetBundle">The bundle that contained the scene.</param>
        /// <param name="_sceneName">The name of the scene to unload.</param>
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

        /// <summary>
        /// Unloads all scenes associated with the provided Asset Bundle.
        /// </summary>
        /// <param name="_assetBundle">The bundle whose scenes should be unloaded.</param>
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