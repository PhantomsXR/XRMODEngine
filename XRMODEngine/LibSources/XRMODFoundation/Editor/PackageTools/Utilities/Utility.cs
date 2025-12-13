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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
#if INSTALL_RUNTIMESERIALIZATION
using Unity.RuntimeSceneSerialization;
#endif
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;


namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public static class Utility
    {
        const string k_Extension = "json";

        public static bool IsCorrectProjectStructure(string _path)
        {
            DirectoryInfo tmp_DirectoryInfo = new DirectoryInfo(_path);
            var tmp_FileInfos = tmp_DirectoryInfo.GetDirectories();
            var tmp_ArtworkFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Artwork")).ToArray().Length > 0;
            var tmp_ScriptsFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Scripts")).ToArray().Length > 0;
            var tmp_CacheFolder = tmp_FileInfos.Where(_info => _info.Name.Equals("Cache")).ToArray().Length > 0;
            return tmp_ArtworkFolder && tmp_ScriptsFolder && tmp_CacheFolder;
        }

        public static bool IsUrl(string _str)
        {
            try
            {
                const string tmp_URL = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
                return Regex.IsMatch(_str, tmp_URL);
            }
            catch (Exception tmp_Ex)
            {
                Debug.LogError(tmp_Ex.Message);
                return false;
            }
        }

        public static string GetRootDataPath(string _fileName = null)
        {
            var tmp_DataPath = $"Assets/{ConstKey.TOOLS_DATA_CACHE_FOLDER}/Data/";
            if (!Directory.Exists(tmp_DataPath))
                Directory.CreateDirectory(tmp_DataPath);
            return string.IsNullOrEmpty(_fileName) ? tmp_DataPath : Path.Combine(tmp_DataPath, _fileName);
        }


        public static void DrawHorizontalDivLine(int _height = 1)
        {
            Rect tmp_Rect = EditorGUILayout.GetControlRect(false, _height);
            tmp_Rect.height = _height;
            EditorGUI.DrawRect(tmp_Rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        public static string ShortenPath(string _fullPath)
        {
            int tmp_SubStringStartPos = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            return _fullPath.Substring(tmp_SubStringStartPos, _fullPath.Length - tmp_SubStringStartPos);
        }


        /// <summary>
        /// Copy files to the specified directory of the current project
        /// </summary>
        /// <param name="_sourceFilePath">Source file</param>
        /// <param name="_destFilePath">Dest file</param>
        /// <param name="_suffix">file suffix</param>
        /// <returns>Asset path in current project</returns>
        public static string CopyFileToProject(string _sourceFilePath, string _destFilePath, string _suffix = null)
        {
            if (!File.Exists(_sourceFilePath))
            {
                return null;
            }

            string tmp_FileName = new DirectoryInfo(_sourceFilePath).Name.ToLower();
            string tmp_DestPath;
            if (!string.IsNullOrEmpty(_suffix))
                tmp_DestPath = Path.Combine(_destFilePath, tmp_FileName) + "." + _suffix;
            else
                tmp_DestPath = Path.Combine(_destFilePath, tmp_FileName);

            File.Copy(_sourceFilePath, tmp_DestPath, true);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return ShortenPath(tmp_DestPath);
        }


        public static bool RightClicked(Rect _area)
        {
            return Event.current.type == EventType.ContextClick
                   && Event.current.button == 1
                   && _area.Contains(Event.current.mousePosition);
        }


        public static void ReadProjectConfigCache(string _destFilePath, out ProjectModel _projectModel)
        {
            try
            {
                var tmp_AllText = File.ReadAllText(_destFilePath, Encoding.UTF8);
                _projectModel = JsonUtility.FromJson<ProjectModel>(tmp_AllText);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                _projectModel = null;
            }
        }

        internal static async Task<Texture2D> TextureDownloader(string _url)
        {
            if (string.IsNullOrEmpty(_url) || !IsUrl(_url)) return null;
            UnityWebRequest tmp_WebRequest = UnityWebRequestTexture.GetTexture(_url);
            await tmp_WebRequest.SendWebRequest();
            switch (tmp_WebRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.ProtocolError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(tmp_WebRequest.error);
                    break;
            }

            return DownloadHandlerTexture.GetContent(tmp_WebRequest);
        }


        public static string GetScriptAssembliesFolder =>
            Phantom.XRMOD.XRMODPackageTools.Runtime.Utility.GetApplicationDataPath()
                .Replace("Assets", "Library/ScriptAssemblies/");


        /// <summary>
        /// Get the path to the assembly file
        /// </summary>
        /// <param name="_source">The assembly file</param>
        /// <returns>True:Current XR-MOD project has editing,otherwise.</returns>
        public static bool GetProjectScriptAssemblyFullNameLowerCase(out string _source)
        {
            _source = string.Empty;

            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            if (string.IsNullOrEmpty(tmp_ProjectDetailCacheData.Configures.DomainName)) return false;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name);
            _source = $"{tmp_SourceFilePath}.runtime.dll";
            return true;
        }


        /// <summary>
        /// Get the path to the assembly file
        /// </summary>
        /// <param name="_source">The assembly file</param>
        /// <returns>True:Current XR-MOD project has editing,otherwise.</returns>
        public static bool GetProjectScriptAssemblyFullNameNormal(out string _source)
        {
            _source = string.Empty;

            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            if (string.IsNullOrEmpty(tmp_ProjectDetailCacheData.Configures.DomainName)) return false;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name);
            _source = $"{tmp_SourceFilePath}.Runtime.dll";
            return true;
        }


        /// <summary>
        /// Get the path to the assembly file
        /// </summary>
        /// <param name="_source">The assembly file</param>
        /// <returns>True:Current XR-MOD project has editing,otherwise.</returns>
        public static bool GetCustomPluginAssemblyFullName(out string _source)
        {
            _source = string.Empty;

            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            if (string.IsNullOrEmpty(tmp_ProjectDetailCacheData.Configures.DomainName)) return false;
            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name);
            _source = $"{tmp_SourceFilePath}.runtime.ClrBinding.dll";
            return true;
        }

        public static bool GetRuntimeScriptPath(out string _dest)
        {
            _dest = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            _dest = Path.Combine(tmp_ProjectDetailCacheData.GetProjectPath(), "Scripts/Runtime");

            return true;
        }

        public static bool GetAutomaticGeneratedPath(out string _dest)
        {
            _dest = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;

            _dest = Path.Combine(tmp_ProjectDetailCacheData.GetProjectPath(), "AutomaticGenerated");

            if (!Directory.Exists(_dest))
                Directory.CreateDirectory(_dest);
            return true;
        }

        public static bool GetNamespace(out string _namespace)
        {
            _namespace = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;
            _namespace = tmp_ProjectDetailCacheData.Configures.DomainName;
            return true;
        }

        public static bool GetProjectName(out string _projectName)
        {
            _projectName = String.Empty;
            if (!MakeSureProjectDetailData(out ProjectDetailCacheData tmp_ProjectDetailCacheData)) return false;
            _projectName = tmp_ProjectDetailCacheData.Configures.ProjectName;
            return true;
        }

        public static bool MakeSureProjectDetailData(out ProjectDetailCacheData _data)
        {
            _data = null;
            if (PackageToolsEditor.ALL_PROJECT_CACHE == null) return false;
            if (PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData() == null) return false;
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) return false;
            _data = tmp_EditingProjectData.DetailCacheData;
            return true;
        }

        /// <summary>
        /// Create the script assemble
        /// </summary>
        /// <param name="_fileName"></param>
        /// <param name="_suffix"></param>
        /// <param name="_path"></param>
        /// <param name="_includePlatforms"></param>
        /// <param name="_references"></param>
        public static void GenerationASMDEF(string _fileName, string _suffix, string _path,
            List<string> _includePlatforms,
            List<string> _references)
        {
            var tmp_FileName = !string.IsNullOrEmpty(_suffix) ? $"{_fileName}.{_suffix}" : _fileName;

            //Create assembly defined
            var tmp_RuntimeAssemblyDefined = new AssemblyDataModel
            {
                name = tmp_FileName,
                autoReferenced = true,
                allowUnsafeCode = true,
                includePlatforms = _includePlatforms,
                references = _references,
                rootNamespace = tmp_FileName
            };

            string tmp_RuntimeAssemblyDefinedJson = JsonUtility.ToJson(tmp_RuntimeAssemblyDefined);
            File.WriteAllText(Path.Combine(_path, $"{tmp_FileName}.asmdef"),
                tmp_RuntimeAssemblyDefinedJson);
        }


        public static BuildTarget GetBuildTarget()
        {
#if UNITY_ANDROID && HANDHELD_ARMODULE_INSTALL
            return BuildTarget.Android;
#elif UNITY_IOS && HANDHELD_ARMODULE_INSTALL
            return BuildTarget.iOS;
#elif UNITY_ANDROID && (PICO_MODULE_INSTALL || ROKID_MODULE_INSTALL || QUEST_MODULE_INSTALL || XREAL_MODULE_INSTALL)
            return BuildTarget.Android;
#elif UNITY_VISIONOS
            return BuildTarget.VisionOS;
#elif UNITY_EDITOR_WIN
            return BuildTarget.StandaloneWindows64;
#elif UNITY_EDITOR_OSX
            return BuildTarget.StandaloneOSX;
#elif UNITY_EDITOR && (!UNITY_EDITOR_OSX||!UNITY_EDITOR_WIN)
            return BuildTarget.StandaloneLinux64;
#endif
        }

        public static BuildTargetGroup GetBuildTargetGroup()
        {
#if UNITY_ANDROID && HANDHELD_ARMODULE_INSTALL
            return BuildTargetGroup.Android;
#elif UNITY_IOS && HANDHELD_ARMODULE_INSTALL
            return BuildTargetGroup.iOS;
#elif UNITY_ANDROID && (PICO_MODULE_INSTALL || ROKID_MODULE_INSTALL || QUEST_MODULE_INSTALL || XREAL_MODULE_INSTALL)
            return BuildTargetGroup.Android;
#elif UNITY_VISIONOS
            return BuildTargetGroup.VisionOS;
#elif UNITY_EDITOR_OSX || UNITY_EDITOR_WIN || UNITY_EDITOR
            return BuildTargetGroup.Standalone;
#endif
        }

        public static BuildTarget GetBuildTargetViaSDKDeviceType(SDKDeviceType _platformName)
        {
            switch (_platformName)
            {
                case SDKDeviceType.VisionOS:
                    return BuildTarget.VisionOS;
                case SDKDeviceType.HandheldAR:
#if UNITY_IOS
                    return BuildTarget.iOS;
#elif UNITY_ANDROID
                    return BuildTarget.Android;
#endif
                    break;
                case SDKDeviceType.Hololens:
                    return BuildTarget.WSAPlayer;
                case SDKDeviceType.Pico:
                case SDKDeviceType.Quest:
                case SDKDeviceType.Rokid:
                case SDKDeviceType.XReal:
                    return BuildTarget.Android;
                case SDKDeviceType.WebAR:
                case SDKDeviceType.WebVR:
                case SDKDeviceType.Classic3D:
                case SDKDeviceType.Web3D:
                default:
                    break;
            }
#if UNITY_EDITOR_WIN
                    return BuildTarget.StandaloneWindows64;
#elif UNITY_EDITOR_OSX
            return BuildTarget.StandaloneOSX;
#elif UNITY_EDITOR && (!UNITY_EDITOR_OSX||!UNITY_EDITOR_WIN)
                    return BuildTarget.StandaloneLinux64;
#endif
        }

        public static BuildTargetGroup GetBuildTargetGroupViaSDKDeviceType(SDKDeviceType _platformName)
        {
            switch (_platformName)
            {
                case SDKDeviceType.VisionOS:
                    return BuildTargetGroup.VisionOS;
                case SDKDeviceType.HandheldAR:
#if UNITY_IOS
                    return BuildTargetGroup.iOS;
#elif UNITY_ANDROID
                    return BuildTargetGroup.Android;
#endif
                    break;
                case SDKDeviceType.Hololens:
                    return BuildTargetGroup.WSA;
                case SDKDeviceType.Pico:
                case SDKDeviceType.Quest:
                case SDKDeviceType.Rokid:
                case SDKDeviceType.XReal:
                    return BuildTargetGroup.Android;
                case SDKDeviceType.WebAR:
                case SDKDeviceType.WebVR:
                case SDKDeviceType.Classic3D:
                case SDKDeviceType.Web3D:
                default:
                    break;
            }

            return BuildTargetGroup.Standalone;
        }

        public static void CopyFolder(string _sourceFolderPath, string _destinationFolderPath)
        {
            // 检查源文件夹是否存在
            if (!Directory.Exists(_sourceFolderPath))
            {
                Console.WriteLine($"源文件夹 {_sourceFolderPath} 不存在。");
                return;
            }

            // 检查目标文件夹是否存在，如果不存在则创建它
            if (!Directory.Exists(_destinationFolderPath))
            {
                Directory.CreateDirectory(_destinationFolderPath);
            }

            // 获取源文件夹中的所有文件和子文件夹
            string[] tmp_Files = Directory.GetFiles(_sourceFolderPath);
            string[] tmp_Folders = Directory.GetDirectories(_sourceFolderPath);

            // 遍历文件并复制它们
            foreach (string tmp_File in tmp_Files)
            {
                string tmp_FileName = Path.GetFileName(tmp_File);
                string tmp_DestinationFilePath = Path.Combine(_destinationFolderPath, tmp_FileName);
                File.Copy(tmp_File, tmp_DestinationFilePath, true);
                Console.WriteLine($"已复制文件 {tmp_FileName}。");
            }

            // 递归复制子文件夹
            foreach (string folder in tmp_Folders)
            {
                CopyFolder(folder, Path.Combine(_destinationFolderPath, Path.GetFileName(folder)));
            }
        }


        public static string CalculateMD5Hash(string _input)
        {
            // 将输入字符串转换为字节数组
            // 推荐使用 UTF8 编码
            byte[] tmp_InputBytes = Encoding.UTF8.GetBytes(_input);

            // 创建 MD5 哈希算法实例
            using MD5 tmp_MD5 = MD5.Create();
            // 计算哈希值
            var tmp_HashBytes = tmp_MD5.ComputeHash(tmp_InputBytes);

            StringBuilder tmp_Sb = new StringBuilder();
            foreach (var tmp_HashByte in tmp_HashBytes)
            {
                // x2 表示十六进制，两位，不足补0
                tmp_Sb.Append(tmp_HashByte.ToString("x2"));
            }

            return tmp_Sb.ToString();
        }

        public static void CreateRuntimeAssetReferenceDatabase(string _savePath)
        {
            string tmp_FileName = $"{nameof(RuntimeAssetReferenceDatabase)}.asset";
            string tmp_CreateFilePath = Path.Combine(_savePath, "Cache");
            if (!Directory.Exists(tmp_CreateFilePath))
                Directory.CreateDirectory(tmp_CreateFilePath);

            string tmp_FilePath = ShortenPath(Path.Combine(tmp_CreateFilePath, tmp_FileName));
#if UNITY_6000_0_OR_NEWER
            if (AssetDatabase.AssetPathExists(tmp_FilePath))
            {
                return;
            }
#else
            if (!AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(tmp_FilePath))
            {
                return;
            }
#endif

            var tmp_Rardb = ScriptableObject.CreateInstance<RuntimeAssetReferenceDatabase>();
            AssetDatabase.CreateAsset(tmp_Rardb, tmp_FilePath);
            EditorUtility.SetDirty(tmp_Rardb);
            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
        }

        // 判断是否为合法类名
        public static bool IsValidClassName(string _name)
        {
            return Regex.IsMatch(_name, @"^[_\p{L}][_\p{L}\p{N}]*$");
        }

        public static bool IsValidProject(string _name)
        {
            return PackageToolsEditor.ALL_PROJECT_CACHE.ProjectCacheDataList.Find(_d =>
                _d.Project.DisplayName == _name) == null;
        }
    }
}