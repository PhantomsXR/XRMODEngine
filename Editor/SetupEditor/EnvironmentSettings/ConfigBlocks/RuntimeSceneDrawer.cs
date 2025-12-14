// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class RuntimeSceneDrawer : AbstractDrawer,IFixer
    {
        private static readonly string[] ALL_SCENES_NAME = {"Initilizer.unity", "Main.unity", "Clear.unity"};
        private static readonly string SCENES_PATH = $"Packages/com.phantomsxr.foundation/Assets/Scenes/Release";
        private const string SCENE_HELP = "Click 'Fix' Button to setup necessary scenes for your App, please.";


        readonly List<SceneAsset> sceneAssets = new();
        readonly List<EditorBuildSettingsScene> editorBuildSettingsScenes = new();

        public RuntimeSceneDrawer()
        {
            GetScenes();
        }

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Runtime Scenes", SCENE_HELP, () => CheckScenes(),
                base.CheckedTexture, base.ErrorTexture, AddScenesToBuildSetting);
        }

        private void GetScenes()
        {
            //sceneAssets.Clear();

            foreach (string tmp_SceneName in ALL_SCENES_NAME)
            {
                SceneAsset tmp_SceneAsset =
                    AssetDatabase.LoadAssetAtPath<SceneAsset>(Path.Combine(SCENES_PATH, tmp_SceneName));
                if (tmp_SceneAsset == null)
                {
                    tmp_SceneAsset =
                        AssetDatabase.LoadAssetAtPath<SceneAsset>(Path.Combine("Assets/Artwork/Scenes/Release",
                            tmp_SceneName));
                }

                if (!tmp_SceneAsset || sceneAssets.Contains(tmp_SceneAsset))
                    continue;
                sceneAssets.Add(tmp_SceneAsset);
            }
        }

        private bool CheckScenes()
        {
            var tmp_ScenesInBuild = EditorBuildSettings.scenes
                .Where(scene => scene.enabled)
                .Select(_scene => Path.GetFileName(_scene.path))
                .ToList();

            int[] tmp_Indices = ALL_SCENES_NAME.Select(_scene => tmp_ScenesInBuild.IndexOf(_scene)).ToArray();

            // 如果任何requiredScenes场景没有在Build Settings中，返回false
            if (tmp_Indices.Any(_index => _index == -1))
                return false;

            // 检查索引顺序是否连续且按照requiredScenes的顺序排列
            for (int tmp_Idx = 1; tmp_Idx < tmp_Indices.Length; tmp_Idx++)
            {
                if (tmp_Indices[tmp_Idx] - tmp_Indices[tmp_Idx - 1] != 1)
                    return false;
            }

            return true;
        }

        private void AddScenesToBuildSetting()
        {
            editorBuildSettingsScenes.Clear();
            var tmp_TempScenes = new List<EditorBuildSettingsScene>(EditorBuildSettings.scenes);
            foreach (SceneAsset tmp_SceneAsset in sceneAssets)
            {
                string tmp_SceneAssetPath = AssetDatabase.GetAssetPath(tmp_SceneAsset);
                
                if (string.IsNullOrEmpty(tmp_SceneAssetPath)) continue;
                
                var tmp_SceneName = Path.GetFileName(tmp_SceneAssetPath);
                var tmp_FoundIdx =
                    tmp_TempScenes.FindIndex(_sceneAsset => _sceneAsset.path.Contains(tmp_SceneName));
                if (tmp_FoundIdx >= 0)
                {
                    tmp_TempScenes.RemoveAt(tmp_FoundIdx);
                }

                editorBuildSettingsScenes.Add(new EditorBuildSettingsScene(tmp_SceneAssetPath, true));
            }

            editorBuildSettingsScenes.InsertRange(0, tmp_TempScenes);
            EditorBuildSettings.scenes = editorBuildSettingsScenes.ToArray();
        }

        void IFixer.DoFix()
        {
            AddScenesToBuildSetting();
        }
    }
}