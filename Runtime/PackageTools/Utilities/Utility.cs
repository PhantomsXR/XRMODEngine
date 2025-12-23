// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    /// <summary>
    /// General-purpose utility class for file searching, path manipulation, and type mapping
    /// within the XRMOD package management system.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Gets the data path for the application, handling specific overrides for multiplayer play mode if active.
        /// </summary>
        /// <returns>The resolved application data path.</returns>
        public static string GetApplicationDataPath()
        {
            string tmp_UnityProjectPath = Application.dataPath;
#if USE_MPPM
#if USE_MPPM_2_0
            if (!Unity.Multiplayer.PlayMode.CurrentPlayer.IsMainEditor)
#elif USE_MPPM
                 if (!Unity.Multiplayer.Playmode.CurrentPlayer.IsMainEditor)
#endif
            {
                var tmp_DataPath = Application.dataPath;
                var tmp_LibraryFolderIndexAtThePath = tmp_DataPath.IndexOf("Library", StringComparison.Ordinal);
                var tmp_MainEditorDataPath =
                    tmp_DataPath.Substring(0, tmp_LibraryFolderIndexAtThePath);
                tmp_UnityProjectPath = Path.Combine(tmp_MainEditorDataPath, "Assets");
            }
#endif
            return tmp_UnityProjectPath;
        }

        /// <summary>
        /// Searches for a directory by its name within the application's data path.
        /// </summary>
        /// <param name="_folderName">The name of the folder to search for.</param>
        /// <returns>The full path to the folder if found; otherwise, an empty string.</returns>
        public static string SearchFolderByName(string _folderName)
        {
            if (string.IsNullOrEmpty(_folderName))
                return string.Empty;
            string tmp_UnityProjectPath = GetApplicationDataPath();
            var tmp_Directories = Directory.GetDirectories(tmp_UnityProjectPath, "*", SearchOption.AllDirectories);
            var tmp_Match = tmp_Directories
                .FirstOrDefault(_path =>
                    new DirectoryInfo(_path).Name.Equals(_folderName, StringComparison.OrdinalIgnoreCase));

            return tmp_Match ?? string.Empty;
        }


        public static string SearchFileByName(string _rootPath, string _fileName, string _suffix = "*")
        {
            switch (_suffix)
            {
                case "ScriptableObject":
                case "Mesh":
                    _suffix = "asset";
                    break;
                case "Sprite":
                case "AudioClip":
                case "VideoClip":
                    _suffix = "*";
                    break;
            }

            string tmp_SearchPattern = $"{_fileName}.{_suffix}";
            string[] tmp_FilesPaths;
            try
            {
                tmp_FilesPaths =
                    Directory.GetFiles(_rootPath, tmp_SearchPattern, SearchOption.AllDirectories);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"SearchFileByName failed: {tmp_Exception.Message}");
                return null;
            }

            return tmp_FilesPaths.Length > 0 ? tmp_FilesPaths[0] : null;
        }

        public static string ShortenPath(string _fullPath)
        {
            var tmp_AssetIdx = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            var tmp_ShortenPath = _fullPath.Substring(tmp_AssetIdx, _fullPath.Length - tmp_AssetIdx);
            return tmp_ShortenPath;
        }

        /// <summary>
        /// Maps a Unity Object type to its common file extension.
        /// </summary>
        /// <typeparam name="T">The type of Unity Object.</typeparam>
        /// <returns>The file extension (without the dot) associated with the type.</returns>
        public static string TypeMapping<T>() where T : UnityEngine.Object
        {
            var tmp_Type = typeof(T);
            string tmp_Suffix = "*";
            if (tmp_Type == typeof(GameObject))
            {
                tmp_Suffix = "prefab";
            }
// ... (rest of the method)
            else if (tmp_Type == typeof(Animator))
            {
                tmp_Suffix = "controller";
            }
            else if (tmp_Type == typeof(AnimationClip))
            {
                tmp_Suffix = "ani";
            }
            else if (tmp_Type == typeof(AudioClip))
            {
                tmp_Suffix = "AudioClip";
            }
            else if (tmp_Type == typeof(Material))
            {
                tmp_Suffix = "Material";
            }
            else if (tmp_Type == typeof(Texture2D))
            {
                tmp_Suffix = "Texture2D";
            }
            else if (tmp_Type == typeof(Mesh))
            {
                tmp_Suffix = "Mesh";
            }
            else if (tmp_Type == typeof(ScriptableObject) || tmp_Type.IsSubclassOf(typeof(ScriptableObject)))
            {
                tmp_Suffix = "ScriptableObject";
            }
            else if (tmp_Type == typeof(Shader))
            {
                tmp_Suffix = "Shader";
            }
            else if (tmp_Type == typeof(VideoClip))
            {
                tmp_Suffix = "VideoClip";
            }
            else if (tmp_Type == typeof(Sprite))
            {
                tmp_Suffix = "Sprite";
            }
            else if (tmp_Type == typeof(SpriteAtlas))
            {
                tmp_Suffix = "SpriteAtlas";
            }
            else if (tmp_Type == typeof(AudioMixer))
            {
                tmp_Suffix = "mixer";
            }
            else if (tmp_Type == typeof(ShaderVariantCollection))
            {
                tmp_Suffix = "shadervariants";
            }

            return tmp_Suffix;
        }

        internal static async void FixEditorAndroidShaders()
        {
#if UNITY_ANDROID && UNITY_EDITOR
            await Task.Delay(1);
            var tmp_AllRenderers =
                Object.FindObjectsByType<Renderer>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            foreach (Renderer tmp_Renderer in tmp_AllRenderers)
            {
                foreach (Material tmp_Mat in tmp_Renderer.materials)
                {
                    tmp_Mat.shader = Shader.Find(tmp_Mat.shader.name);
                }
            }

#else
            await Task.Yield();
#endif
        }
    }
}