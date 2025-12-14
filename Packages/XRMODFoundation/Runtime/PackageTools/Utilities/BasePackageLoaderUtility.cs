/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Cysharp.Threading.Tasks;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;
using Progress = Cysharp.Threading.Tasks.Progress;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine.Assertions;

#endif

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    /// <summary>
    /// Provides utility methods for loading and managing asset bundles and assets within the XRMOD framework.
    /// Handles both local file loading and remote URL loading with caching mechanisms.
    /// </summary>
    public static class BasePackageLoaderUtility
    {
        /// <summary>
        /// A collection of all loaded AssetBundles, mapped by their file names.
        /// </summary>
        private static readonly IDictionary<string, AssetBundle> AssetBundleCollection =
            new Dictionary<string, AssetBundle>();


        private static string[] _PACKAGE_NAMES = new[]
        {
            ".arexperience",
            ".xrexperience",
            ".spatial",
            ".package",
            ".xrmod",
        };

        /// <summary>
        /// Determines whether assets should be loaded from remote sources (true) or local editor paths (false).
        /// This flag is primarily used for development and testing in the Unity Editor.
        /// </summary>
        public static bool LoadFromRemote = false;


        private static readonly HashSet<string> _COMMON_LOAD_FILE_FILTERS =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "ARProperty",
                "LocalizationTable.csv",
                "LocalizationDatabase",
                "RuntimeAssetReferenceDatabase",
            };

        private static readonly Dictionary<string, HashSet<string>> _LOAD_FILE_FILTER_CACHE = new();

        /// <summary>
        /// Retrieves a list of file names that should be filtered during asset loading,
        /// typically for assets that do not need to be loaded from temporary asset folders.
        /// </summary>
        /// <param name="_projectName">The name of the project to get filters for.</param>
        /// <returns>An array of file name strings to filter.</returns>
        private static HashSet<string> GetLoadFileFilters(string _projectName)
        {
            if (_LOAD_FILE_FILTER_CACHE.TryGetValue(_projectName, out var tmp_Cached))
                return tmp_Cached;

            var tmp_NewFilter = new HashSet<string>(_COMMON_LOAD_FILE_FILTERS)
            {
                $"{_projectName}.runtime.dll".ToLower(),
                $"{_projectName}.runtime.pdb".ToLower()
            };

            _LOAD_FILE_FILTER_CACHE[_projectName] = tmp_NewFilter;
            return tmp_NewFilter;
        }


        /// <summary>
        /// Asynchronously loads a specific asset from a local asset bundle file.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_pathWithFile">The full path to the asset bundle file.</param>
        /// <param name="_wannaLoadAssetsName">The name of the asset to load from the bundle.</param>
        /// <param name="_loadFinished">Callback invoked upon successful asset loading, providing the loaded asset.</param>
        /// <param name="_loadFailed">Callback invoked if asset loading fails, providing an error message.</param>
        public static void LoadAssetFromFileAsync<T>(string _pathWithFile, string _wannaLoadAssetsName,
            Action<T> _loadFinished, Action<string> _loadFailed) where T : Object
        {
#if UNITY_EDITOR
            var tmp_BuildTimer = new Stopwatch();
            tmp_BuildTimer.Start();
#endif
            try
            {
                if (string.IsNullOrEmpty(_pathWithFile))
                {
                    _loadFailed?.Invoke($"Load asset failed at {_pathWithFile}.");
                    throw new Exception($"Load asset failed at {_pathWithFile}.");
                }

                string tmp_BundleName = Path.GetFileName(_pathWithFile);

                // If the asset bundle is already loaded, reload the asset from the existing bundle.
                if (AssetBundleCollection.TryGetValue(tmp_BundleName, out AssetBundle tmp_LoadedAssetBundle))
                {
                    var tmp_ReloadAsset = tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName);

                    tmp_ReloadAsset.completed += _asyncOperation =>
                    {
                        if (tmp_ReloadAsset.asset == null)
                            throw new Exception($"Load asset failed at {_pathWithFile}.");
                        _loadFinished?.Invoke(tmp_ReloadAsset.asset as T);
#if UNITY_EDITOR
                        tmp_BuildTimer.Stop();
                        Debug.Log($"ReLoad:{tmp_BuildTimer.ElapsedMilliseconds} ms");
#endif
                    };
                    return;
                }

                // Load the asset bundle from file and then load the asset.
                var tmp_AssetBundleCreateRequest = AssetBundle.LoadFromFileAsync(_pathWithFile);
                tmp_AssetBundleCreateRequest.completed += _operation =>
                {
                    var tmp_AssetBundle = tmp_AssetBundleCreateRequest.assetBundle;
                    var tmp_LoadedAsset = tmp_AssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                    tmp_LoadedAsset.completed += _asyncOperation =>
                    {
                        if (tmp_LoadedAsset.asset == null)
                            throw new Exception($"Load asset failed at {_pathWithFile}.");

                        AddAssetBundleToGlobalManager(tmp_AssetBundle.name, tmp_AssetBundle);
                        _loadFinished?.Invoke(tmp_LoadedAsset.asset as T);
#if UNITY_EDITOR
                        tmp_BuildTimer.Stop();
                        Debug.Log($"ReLoad:{tmp_BuildTimer.ElapsedMilliseconds} ms");
#endif
                    };
                };
            }
            catch (Exception tmp_Exception)
            {
                _loadFailed?.Invoke(tmp_Exception.Message);
                throw new Exception($"Load asset failed at {_pathWithFile}.", tmp_Exception);
            }
        }

        #region Obsolete

        /// <summary>
        /// Asynchronously loads a specific asset from an asset bundle downloaded from a URL.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_uri">The URI of the asset bundle to download.</param>
        /// <param name="_wannaLoadAssetsName">The name of the asset to load from the bundle.</param>
        /// <param name="_hash">A version hash for caching. If it doesn't match, the bundle will be re-downloaded.</param>
        /// <param name="_crc">A checksum for data integrity. If zero, CRC checking is skipped.</param>
        /// <param name="_loadFinished">Callback invoked upon successful asset loading, providing the loaded asset.</param>
        /// <param name="_loadFailed">Callback invoked if asset loading fails, providing an error message.</param>
        /// <param name="_downloadProgressCallback">Callback invoked to report download progress (0.0 to 1.0).</param>
        [Obsolete("This method will be removed in future updates. Use LoadBundleFromUrl(Async) instead.")]
        public static IEnumerator LoadGameObjectFromUrl<T>(Uri _uri, string _wannaLoadAssetsName, Hash128 _hash,
            uint _crc,
            Action<T> _loadFinished,
            Action<string> _loadFailed,
            Action<float> _downloadProgressCallback) where T : Object
        {
#if UNITY_EDITOR
            var tmp_BuildTimer = new Stopwatch();
            tmp_BuildTimer.Start();
#endif

            var tmp_FileName = Path.GetFileName(_uri.AbsoluteUri).Split("?")[0];
            var tmp_CachedConfigure = new CachedAssetBundle {hash = _hash};

            // If the asset bundle is already loaded, reload the asset from the existing bundle.
            if (AssetBundleCollection.TryGetValue(tmp_FileName, out AssetBundle tmp_LoadedAssetBundle))
            {
                var tmp_ReloadAsset = tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName);

                tmp_ReloadAsset.completed += _asyncOperation =>
                {
                    if (tmp_ReloadAsset.asset == null)
                        throw new Exception($"Load asset failed at {_uri.AbsoluteUri}.");

                    _loadFinished?.Invoke(tmp_ReloadAsset.asset as T);
#if UNITY_EDITOR
                    tmp_BuildTimer.Stop();
                    Debug.Log($"Re Load:{tmp_BuildTimer.ElapsedMilliseconds} ms");
#endif
                };
                yield return null;
            }

            // Download the asset bundle from the URL.
            var tmp_WebRequestAssetBundle = UnityWebRequestAssetBundle.GetAssetBundle(_uri, tmp_CachedConfigure, _crc);

            yield return tmp_WebRequestAssetBundle.SendWebRequest();

            switch (tmp_WebRequestAssetBundle.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.ProtocolError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(tmp_WebRequestAssetBundle.error);
                    _loadFailed?.Invoke(tmp_WebRequestAssetBundle.error);
                    tmp_WebRequestAssetBundle.Dispose();
                    yield break;
            }

            while (!tmp_WebRequestAssetBundle.isDone)
            {
                _downloadProgressCallback?.Invoke(tmp_WebRequestAssetBundle.downloadProgress);
                yield return null;
            }

            try
            {
                AssetBundle tmp_AssetBundle = DownloadHandlerAssetBundle.GetContent(tmp_WebRequestAssetBundle);

                var tmp_LoadedAsset = tmp_AssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                tmp_LoadedAsset.completed += _asyncOperation =>
                {
                    if (tmp_LoadedAsset.asset == null)
                        throw new Exception($"Load asset failed at {_uri.AbsoluteUri}.");

                    AddAssetBundleToGlobalManager(tmp_AssetBundle.name, tmp_AssetBundle);
                    _loadFinished?.Invoke(tmp_LoadedAsset.asset as T);
#if UNITY_EDITOR
                    tmp_BuildTimer.Stop();
                    Debug.Log($"First Load:{tmp_BuildTimer.ElapsedMilliseconds} ms");
#endif
                };
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Loads a specific asset from a package by project name.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_projectName">The name of the project (which corresponds to the asset bundle name).</param>
        /// <param name="_wannaLoadedAssetName">The name of the asset to load.</param>
        /// <param name="_loadedCallback">Callback invoked upon successful asset loading, providing the loaded asset.</param>
        [Obsolete("This method will be removed in future updates. Use LoadAssetFromPackage(Async) instead.")]
        public static void LoadAssetFromPackage<T>(string _projectName, string _wannaLoadedAssetName,
            Action<T> _loadedCallback) where T : Object
        {
            try
            {
#if UNITY_EDITOR
                if (!LoadFromRemote)
                {
                    string tmp_Suffix = Utility.TypeMapping<T>();
                    var tmp_FullPath = Utility.SearchFolderByName(_projectName);
                    string tmp_FilePath = string.Empty;
                    if (!string.IsNullOrEmpty(tmp_FullPath))
                        tmp_FilePath =
                            Utility.SearchFileByName(tmp_FullPath, _wannaLoadedAssetName, tmp_Suffix);
                    if (string.IsNullOrEmpty(tmp_FilePath) || !File.Exists(tmp_FullPath))
                    {
                        var tmp_SearchResultGuids = AssetDatabase.FindAssets($"t:{tmp_Suffix}",
                            new[] {Utility.ShortenPath(tmp_FullPath)});

                        foreach (string tmp_Guid in tmp_SearchResultGuids)
                        {
                            string tmp_Path = AssetDatabase.GUIDToAssetPath(tmp_Guid);
                            if (Path.GetFileNameWithoutExtension(tmp_Path) == _wannaLoadedAssetName &&
                                File.Exists(Path.Combine(Application.dataPath.Replace("Assets", ""), tmp_Path)))
                            {
                                tmp_FilePath = tmp_Path;
                                break;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(tmp_FilePath))
                    {
                        var tmp_ShortenPath = Utility.ShortenPath(tmp_FilePath);
                        var tmp_Asset = AssetDatabase.LoadAssetAtPath<T>(tmp_ShortenPath);
                        if (tmp_Asset == null)
                            throw new Exception($"Load {_wannaLoadedAssetName} asset failed.");
                        _loadedCallback?.Invoke(tmp_Asset);
                    }
                    else
                    {
                        _projectName += ".arexperience";
                        if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                                out AssetBundle tmp_MatchedAssetBundle))
                        {
                            throw new NullReferenceException(
                                $"Can not load {_projectName} project's {_wannaLoadedAssetName} asset.");
                        }

                        var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAssetAsync(_wannaLoadedAssetName);
                        tmp_LoadedOperation.completed += _operation =>
                        {
                            if (tmp_LoadedOperation.asset == null)
                                throw new Exception($"Load {_wannaLoadedAssetName} asset failed.");
                            _loadedCallback?.Invoke(tmp_LoadedOperation.asset as T);
                        };
                    }

                    return;
                }
#endif
                {
                    _projectName += ".arexperience";
                    if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                            out AssetBundle tmp_MatchedAssetBundle))
                    {
                        throw new NullReferenceException(
                            $"Can not load {_projectName} project's {_wannaLoadedAssetName} asset.");
                    }

                    var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAssetAsync(_wannaLoadedAssetName);
                    tmp_LoadedOperation.completed += _operation =>
                    {
                        if (tmp_LoadedOperation.asset == null)
                            throw new Exception($"Load {_wannaLoadedAssetName} asset failed.");
                        _loadedCallback?.Invoke(tmp_LoadedOperation.asset as T);
                    };
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        #endregion

        /// <summary>
        /// Asynchronously loads a specific asset from a package by project name.
        /// In editor, it attempts to load directly from project assets first, then falls back to asset bundles.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_projectName">The name of the project (which corresponds to the asset bundle name).</param>
        /// <param name="_wannaLoadedAssetName">The name of the asset to load.</param>
        /// <returns>A Task representing the asynchronous operation, yielding the loaded asset.</returns>
        /// <exception cref="NullReferenceException">Thrown if the asset bundle cannot be found.</exception>
        /// <exception cref="Exception">Thrown if the asset fails to load.</exception>
        public static async Task<T> LoadAssetFromPackage<T>(string _projectName, string _wannaLoadedAssetName)
            where T : Object
        {
            try
            {
#if UNITY_EDITOR
                if (!LoadFromRemote)
                {
                    // Attempt to load from Unity Editor project assets first.
                    try
                    {
                        string tmp_Suffix = Utility.TypeMapping<T>();
                        var tmp_FullPath = Utility.SearchFolderByName(_projectName);
                        // Prefer original path (not TempAssets) for specific kinds:
                        // 1) Items explicitly listed in load filters
                        // 2) ScriptableObject types
                        // 3) JSON files typically represented as TextAsset in Unity
                        bool tmp_InFilters = GetLoadFileFilters(_projectName).Contains(_wannaLoadedAssetName);
                        bool tmp_IsScriptableObject = typeof(ScriptableObject).IsAssignableFrom(typeof(T));
                        bool tmp_IsJsonOrText = typeof(T) == typeof(TextAsset);

                        // Only redirect to TempAssets when not in filters and not ScriptableObject/TextAsset (json)
                        if (!(tmp_InFilters || tmp_IsScriptableObject || tmp_IsJsonOrText))
                        {
                            tmp_FullPath = Path.Combine(tmp_FullPath, "AutomaticGenerated/TempAssets");
                        }

                        if (string.IsNullOrEmpty(tmp_FullPath))
                            throw new Exception("No cache found. Attempting to load from server (asset bundle).");

                        var tmp_FilePath = Utility.SearchFileByName(tmp_FullPath, _wannaLoadedAssetName, tmp_Suffix);

                        if (!string.IsNullOrEmpty(tmp_FilePath))
                        {
                            T tmp_ResultAsset = AssetDatabase.LoadAssetAtPath<T>(Utility.ShortenPath(tmp_FilePath));
                            if (tmp_ResultAsset != null)
                            { 
                                await Task.Delay(1);
                                return tmp_ResultAsset;
                            }
                        }

                        string[] tmp_Guids = AssetDatabase.FindAssets($"t:{tmp_Suffix}",
                            new[] {Utility.ShortenPath(tmp_FullPath)});
                        foreach (string tmp_Guid in tmp_Guids)
                        {
                            string tmp_Path = AssetDatabase.GUIDToAssetPath(tmp_Guid);
                            if (Path.GetFileNameWithoutExtension(tmp_Path) != _wannaLoadedAssetName) continue;
                            T tmp_FoundAsset = AssetDatabase.LoadAssetAtPath<T>(tmp_Path);
                            if (tmp_FoundAsset == null) continue;
                            await Task.Delay(1);
                            return tmp_FoundAsset;
                        }

                        throw new Exception("No cache found. Attempting to load from server (asset bundle).");
                    }
                    catch (Exception tmp_Exception)
                    {
                        // Fallback to loading from asset bundle if direct editor loading fails.
                        _projectName += ".arexperience";
                        if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                                out AssetBundle tmp_MatchedAssetBundle))
                        {
                            throw new NullReferenceException(
                                $"It cannot load {_wannaLoadedAssetName} asset from {_projectName}.\n {tmp_Exception.Message}");
                        }

                        var tmp_LoadedOperation = await tmp_MatchedAssetBundle.LoadAssetAsync<T>(_wannaLoadedAssetName);
                        if (tmp_LoadedOperation == null)
                            throw new Exception($"Load {_wannaLoadedAssetName} asset failed from package.");
                        return tmp_LoadedOperation as T;
                    }
                }
#endif
                {
                    // Runtime loading from asset bundle.
                    _projectName += ".arexperience";
                    if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                            out AssetBundle tmp_MatchedAssetBundle))
                    {
                        throw new NullReferenceException(
                            $"Can not load {_projectName} project's {_wannaLoadedAssetName} asset.");
                    }

                    var tmp_LoadedOperation = await tmp_MatchedAssetBundle.LoadAssetAsync<T>(_wannaLoadedAssetName);

                    if (tmp_LoadedOperation == null)
                        throw new Exception($"Load {_wannaLoadedAssetName} asset failed.");

                    return tmp_LoadedOperation as T;
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously loads all assets of a specific type from a package by project name.
        /// In editor, it attempts to load directly from project assets first, then falls back to asset bundles.
        /// </summary>
        /// <typeparam name="T">The type of the assets to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_projectName">The name of the project (which corresponds to the asset bundle name).</param>
        /// <returns>A Task representing the asynchronous operation, yielding an array of loaded assets.</returns>
        /// <exception cref="NullReferenceException">Thrown if the asset bundle cannot be found.</exception>
        /// <exception cref="Exception">Thrown if no assets of the specified type are found.</exception>
        public static async Task<T[]> LoadAssetsFromPackage<T>(string _projectName) where T : Object
        {
            try
            {
                if (!LoadFromRemote)
                {
#if UNITY_EDITOR
                    // Attempt to load from Unity Editor project assets first.
                    try
                    {
                        string tmp_Suffix = Utility.TypeMapping<T>();
                        var tmp_FullPath = Utility.SearchFolderByName(_projectName);

                        if (string.IsNullOrEmpty(tmp_FullPath))
                            throw new Exception("No cache found. Attempting to load from server (asset bundle).");

                        var tmp_AllGuids = AssetDatabase.FindAssets($"t:{tmp_Suffix}",
                            new[] {Utility.ShortenPath(tmp_FullPath)});

                        if (tmp_AllGuids.Length <= 0)
                            throw new Exception("No cache found. Attempting to load from server (asset bundle).");
                        // Load with paths so we can de-duplicate by name and prefer non-TempAssets
                        var tmp_AssetInfos = tmp_AllGuids
                            .Select(_guid => new
                            {
                                path = AssetDatabase.GUIDToAssetPath(_guid),
                                asset = (T) AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(_guid))
                            })
                            .Where(_it => _it.asset != null)
                            .ToArray();

                        bool IsTempPath(string p) =>
                            p.IndexOf("/AutomaticGenerated/TempAssets/", StringComparison.OrdinalIgnoreCase) >= 0;

                        var tmp_DistinctAssets = tmp_AssetInfos
                            .GroupBy(_it => _it.asset.name)
                            .Select(_grp => _grp
                                .OrderBy(_it => IsTempPath(_it.path) ? 1 : 0) // prefer non-TempAssets
                                .ThenBy(_it => _it.path, StringComparer.Ordinal)
                                .First().asset)
                            .ToArray();

                        await Task.Delay(1); // keep async symmetry
                        if (tmp_DistinctAssets.Length <= 0)
                            throw new Exception("No cache found. Attempting to load from server (asset bundle).");

                        return tmp_DistinctAssets;
                    }
                    catch (Exception tmp_Exception)
                    {
                        // Fallback to loading from asset bundle if direct editor loading fails.
                        _projectName += ".arexperience";
                        if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                                out AssetBundle tmp_MatchedAssetBundle))
                        {
                            throw new NullReferenceException(
                                $"Can not load {_projectName} project asset.\n {tmp_Exception.Message}");
                        }

                        var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAllAssetsAsync<T>();
                        await tmp_LoadedOperation;

                        var tmp_AllAssets = tmp_LoadedOperation.allAssets as T[];
                        if (tmp_AllAssets == null || tmp_AllAssets.Length == 0)
                            throw new Exception("Nothing to load from server.");
                        return tmp_LoadedOperation.allAssets as T[];
                    }
#endif
                }

                {
                    // Runtime loading from asset bundle.
                    _projectName += ".arexperience";
                    if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                            out AssetBundle tmp_MatchedAssetBundle))
                    {
                        throw new NullReferenceException($"Can not load {_projectName} project asset.");
                    }

                    var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAllAssetsAsync<T>();
                    await tmp_LoadedOperation;
                    List<T> tmp_AllTAssets = new List<T>();
                    foreach (Object tmp_Asset in tmp_LoadedOperation.allAssets)
                    {
                        if (tmp_Asset is T tmp_TAsset)
                        {
                            tmp_AllTAssets.Add(tmp_TAsset);
                        }
                    }

                    var tmp_Assets = tmp_AllTAssets.ToArray();
                    if (tmp_Assets.Length <= 0)
                        throw new Exception($"Nothing to load from {_projectName}.");

                    return tmp_Assets;
                }
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously loads a specific set of named assets of a given type from a package by project name.
        /// In editor, it attempts to load directly from project assets first, then falls back to asset bundles.
        /// </summary>
        /// <typeparam name="T">The type of the assets to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_projectName">The name of the project (which corresponds to the asset bundle name).</param>
        /// <param name="_assetNames">An array of asset names to load.</param>
        /// <returns>A Task representing the asynchronous operation, yielding an array of loaded assets.</returns>
        /// <exception cref="NullReferenceException">Thrown if the asset bundle cannot be found.</exception>
        /// <exception cref="IndexOutOfRangeException">Thrown if any specified asset is not found in the package.</exception>
        public static async Task<T[]> LoadAssetsFromPackage<T>(string _projectName, string[] _assetNames)
            where T : Object
        {
            if (!LoadFromRemote)
            {
#if UNITY_EDITOR
                // Attempt to load from Unity Editor project assets first.
                try
                {
                    string tmp_Suffix = Utility.TypeMapping<T>();
                    var tmp_FullPath = Utility.SearchFolderByName(_projectName);
                    if (string.IsNullOrEmpty(tmp_FullPath))
                        throw new Exception("No cache found. Attempting to load from server (asset bundle).");

                    var tmp_AllAssetGuide = AssetDatabase.FindAssets($"t:{tmp_Suffix}", new[]
                    {
                        Utility.ShortenPath(tmp_FullPath)
                    });

                    var tmp_AllAssetInfos = tmp_AllAssetGuide
                        .Select(AssetDatabase.GUIDToAssetPath)
                        .Select(_path => new {path = _path, asset = (T) AssetDatabase.LoadAssetAtPath<T>(_path)})
                        .Where(_it => _it.asset != null)
                        .ToArray();

                    bool IsTempPath(string p) =>
                        p.IndexOf("/AutomaticGenerated/TempAssets/", StringComparison.OrdinalIgnoreCase) >= 0;

                    // De-duplicate by name with preference: non-TempAssets first
                    var tmp_NameToAsset = tmp_AllAssetInfos
                        .GroupBy(_it => _it.asset.name)
                        .ToDictionary(
                            _grp => _grp.Key,
                            _grp => _grp
                                .OrderBy(_it => IsTempPath(_it.path) ? 1 : 0)
                                .ThenBy(_it => _it.path, StringComparer.Ordinal)
                                .First().asset
                        );

                    if (tmp_NameToAsset.Count < _assetNames.Length)
                    {
                        var tmp_Check1LoadedNames = new HashSet<string>(tmp_NameToAsset.Keys);
                        var tmp_Check1MissingAssets =
                            _assetNames.Where(_name => !tmp_Check1LoadedNames.Contains(_name)).ToArray();

                        if (tmp_Check1MissingAssets.Length > 0)
                        {
                            throw new IndexOutOfRangeException(
                                $"The loaded assets are not in the package. Missing Assets: {string.Join(", ", tmp_Check1MissingAssets)}");
                        }
                    }

                    var tmp_SortedAssets = _assetNames
                        .Select(_name => tmp_NameToAsset.TryGetValue(_name, out var a) ? a : null)
                        .Where(_a => _a != null)
                        .ToArray();

                    if (tmp_SortedAssets.Length >= _assetNames.Length) return tmp_SortedAssets;

                    var tmp_Check2LoadedNames = new HashSet<string>(tmp_SortedAssets.Select(a => a.name));
                    var tmp_Check2MissingAssets =
                        _assetNames.Where(_name => !tmp_Check2LoadedNames.Contains(_name)).ToArray();

                    if (tmp_Check2MissingAssets.Length > 0)
                    {
                        foreach (string tmp_MissingAsset in tmp_Check2MissingAssets)
                        {
                            Debug.LogError(tmp_MissingAsset);
                        }

                        throw new IndexOutOfRangeException(
                            $"The loaded assets are not in the package. Missing Assets[{tmp_Check2MissingAssets.Length}]: {string.Join(", ", tmp_Check2MissingAssets)}");
                    }

                    return tmp_SortedAssets;
                }
                catch (Exception tmp_Exception)
                {
                    // Fallback to loading from asset bundle if direct editor loading fails.
                    _projectName += ".arexperience";
                    if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(),
                            out AssetBundle tmp_MatchedAssetBundle))
                    {
                        throw new NullReferenceException(
                            $"Can not load {_projectName} project asset.\n {tmp_Exception.Message}");
                    }

                    var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAllAssetsAsync<T>();
                    await tmp_LoadedOperation;

                    var tmp_AllTAssets = tmp_LoadedOperation.allAssets
                        .OfType<T>()
                        .ToArray();

                    if (tmp_AllTAssets.Length < _assetNames.Length)
                    {
                        var tmp_Check1LoadedNames = new HashSet<string>(tmp_AllTAssets.Select(a => a.name));
                        var tmp_Check1MissingAssets =
                            _assetNames.Where(_name => !tmp_Check1LoadedNames.Contains(_name)).ToArray();

                        if (tmp_Check1MissingAssets.Length > 0)
                        {
                            throw new IndexOutOfRangeException(
                                $"The loaded assets are not in the package. Missing Assets: {string.Join(", ", tmp_Check1MissingAssets)}");
                        }
                    }

                    var tmp_SortedAssets = _assetNames.Join(tmp_AllTAssets,
                            _assetName => _assetName,
                            _asset => _asset.name,
                            (_assetName, _asset) => _asset)
                        .ToArray();

                    if (tmp_SortedAssets.Length >= _assetNames.Length) return tmp_SortedAssets;

                    var tmp_Check2LoadedNames = new HashSet<string>(tmp_SortedAssets.Select(a => a.name));
                    var tmp_Check2MissingAssets =
                        _assetNames.Where(_name => !tmp_Check2LoadedNames.Contains(_name)).ToArray();

                    if (tmp_Check2MissingAssets.Length > 0)
                    {
                        foreach (string tmp_MissingAsset in tmp_Check2MissingAssets)
                        {
                            Debug.LogError(tmp_MissingAsset);
                        }

                        throw new IndexOutOfRangeException(
                            $"The loaded assets are not in the package. Missing Assets[{tmp_Check2MissingAssets.Length}]: {string.Join(", ", tmp_Check2MissingAssets)}");
                    }

                    return tmp_SortedAssets;
                }
#endif
            }

            {
                // Runtime loading from asset bundle.
                _projectName += ".arexperience";
                if (!AssetBundleCollection.TryGetValue(_projectName.ToLower(), out AssetBundle tmp_MatchedAssetBundle))
                {
                    throw new NullReferenceException($"Can not load {_projectName} project asset.");
                }

                var tmp_LoadedOperation = tmp_MatchedAssetBundle.LoadAllAssetsAsync<T>();
                await tmp_LoadedOperation;

                var tmp_AllTAssets = tmp_LoadedOperation.allAssets
                    .OfType<T>()
                    .ToArray();

                if (tmp_AllTAssets.Length < _assetNames.Length)
                {
                    var tmp_Check1LoadedNames = new HashSet<string>(tmp_AllTAssets.Select(a => a.name));
                    var tmp_Check1MissingAssets =
                        _assetNames.Where(_name => !tmp_Check1LoadedNames.Contains(_name)).ToArray();

                    if (tmp_Check1MissingAssets.Length > 0)
                    {
                        throw new IndexOutOfRangeException(
                            $"The loaded assets are not in the package. Missing Assets: {string.Join(", ", tmp_Check1MissingAssets)}");
                    }
                }

                var tmp_SortedAssets = _assetNames.Join(tmp_AllTAssets,
                        _assetName => _assetName,
                        _asset => _asset.name,
                        (_assetName, _asset) => _asset)
                    .ToArray();

                if (tmp_SortedAssets.Length >= _assetNames.Length) return tmp_SortedAssets;

                var tmp_Check2LoadedNames = new HashSet<string>(tmp_SortedAssets.Select(a => a.name));
                var tmp_Check2MissingAssets =
                    _assetNames.Where(_name => !tmp_Check2LoadedNames.Contains(_name)).ToArray();

                if (tmp_Check2MissingAssets.Length > 0)
                {
                    throw new IndexOutOfRangeException(
                        $"The loaded assets are not in the package. Missing Assets: {string.Join(", ", tmp_Check2MissingAssets)}");
                }

                return tmp_SortedAssets;
            }
        }

        /// <summary>
        /// Asynchronously loads a batch of assets by names from a package and returns a name-to-asset map.
        /// Delegates to <see cref="LoadAssetsFromPackage{T}(string, string[])"/> to ensure assets are
        /// loaded and ordered to match the input names, then builds a dictionary in that order.
        /// </summary>
        /// <typeparam name="T">The type of the assets to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_projectName">The project (package) name.</param>
        /// <param name="_assetNames">The list of asset names to load, in the desired order.</param>
        /// <returns>
        /// A dictionary mapping asset name to asset instance. The insertion order of the dictionary
        /// follows the order of <paramref name="_assetNames"/>. Enumeration over the dictionary will
        /// reflect that order.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="_assetNames"/> is null.</exception>
        /// <exception cref="IndexOutOfRangeException">Propagated if any requested asset is missing.</exception>
        public static async Task<Dictionary<string, T>> LoadAssetsFromPackageAsDictionary<T>(
            string _projectName, string[] _assetNames) where T : Object
        {
            if (_assetNames == null) throw new ArgumentNullException(nameof(_assetNames));

            // Load and sort assets according to input order using the existing API
            var tmp_SortedAssets = await LoadAssetsFromPackage<T>(_projectName, _assetNames);

            // Build a name->asset map preserving insertion order
            var tmp_Result = new Dictionary<string, T>(_assetNames.Length);
            for (int i = 0; i < _assetNames.Length; i++)
            {
                var tmp_Name = _assetNames[i];
                var tmp_Asset = tmp_SortedAssets[i];
                tmp_Result[tmp_Name] = tmp_Asset;
            }

            return tmp_Result;
        }

        /// <summary>
        /// Asynchronously loads a specific asset from an asset bundle downloaded from a URL.
        /// Supports caching and progress reporting.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_uri">The URI of the asset bundle to download.</param>
        /// <param name="_timeout">The timeout duration for the web request in seconds.</param>
        /// <param name="_wannaLoadAssetsName">The name of the asset to load from the bundle.</param>
        /// <param name="_hash128">A version hash for caching. If it doesn't match, the bundle will be re-downloaded.</param>
        /// <param name="_crc">A checksum for data integrity. If zero, CRC checking is skipped.</param>
        /// <param name="_progressAction">Callback invoked to report download progress (0.0 to 1.0).</param>
        /// <param name="_failedAction">Callback invoked if asset loading fails, providing an error message.</param>
        /// <returns>A Task representing the asynchronous operation, yielding the loaded asset.</returns>
        public static async Task<T> LoadBundleFromUrl<T>(Uri _uri, int _timeout, string _wannaLoadAssetsName,
            Hash128 _hash128, uint _crc, Action<float> _progressAction, Action<string> _failedAction)
            where T : Object
        {
            var tmp_FileName = Path.GetFileName(_uri.AbsoluteUri).Split('?')[0];
            var tmp_CachedConfigure = new CachedAssetBundle {hash = _hash128};

            // If the asset bundle is already loaded, reload the asset from the existing bundle.
            if (AssetBundleCollection.TryGetValue(tmp_FileName, out AssetBundle tmp_LoadedAssetBundle))
            {
                tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName).GetAwaiter();
                var tmp_ReloadAsset = await tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                return tmp_ReloadAsset as T;
            }

#if !UNITY_EDITOR
            // Auto clean-up old assets only work in real-devices
            if (!Caching.IsVersionCached(_uri.ToString(), tmp_CachedConfigure.hash))
            {
                var tmp_OldAssetsbundleName = Path.GetFileNameWithoutExtension(_uri.AbsolutePath);
                var tmp_CachePath =
                    $"{Application.temporaryCachePath.Replace("Caches", "UnityCache")}/Shared/{tmp_OldAssetsbundleName}";
                if (Directory.Exists(tmp_CachePath))
                {
                    var tmp_AllCacheDirectories = Directory.GetDirectories(tmp_CachePath);
                    for (int tmp_DirectoryIdx = 0;
                         tmp_DirectoryIdx < tmp_AllCacheDirectories.Length;
                         tmp_DirectoryIdx++)
                    {
                        Hash128 tmp_Hash128 =
                            Hash128.Parse(Path.GetFileName(tmp_AllCacheDirectories[tmp_DirectoryIdx]));
                        bool tmp_IsClearCached =
                            Caching.ClearCachedVersion(tmp_OldAssetsbundleName, tmp_Hash128);
                        if (tmp_IsClearCached)
                        {
#if UNITY_EDITOR
                            Debug.Log($"{tmp_OldAssetsbundleName}->{tmp_Hash128} asset was cleaned.");
#endif
                        }
                    }
                }
            }
#endif

            var tmp_Progress = Progress.Create(_progressAction);

            var tmp_WebRequestAssetBundle =
                UnityWebRequestAssetBundle.GetAssetBundle(_uri, tmp_CachedConfigure, _crc);
            await tmp_WebRequestAssetBundle.SendWebRequest().ToUniTask(progress: tmp_Progress);

            try
            {
                AssetBundle tmp_AssetBundle = DownloadHandlerAssetBundle.GetContent(tmp_WebRequestAssetBundle);
                var tmp_LoadedAsset = await tmp_AssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                AddAssetBundleToGlobalManager(tmp_AssetBundle.name, tmp_AssetBundle);
                return tmp_LoadedAsset as T;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load package failed: {tmp_Exception.Message}");
                _failedAction?.Invoke(tmp_Exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously loads a specific asset from an asset bundle downloaded from a URL string.
        /// Supports caching and progress reporting.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_uri">The URI string of the asset bundle to download.</param>
        /// <param name="_timeout">The timeout duration for the web request in seconds.</param>
        /// <param name="_wannaLoadAssetsName">The name of the asset to load from the bundle.</param>
        /// <param name="_hash128">A version hash for caching. If it doesn't match, the bundle will be re-downloaded.</param>
        /// <param name="_crc">A checksum for data integrity. If zero, CRC checking is skipped.</param>
        /// <param name="_progressAction">Callback invoked to report download progress (0.0 to 1.0).</param>
        /// <param name="_failedAction">Callback invoked if asset loading fails, providing an error message.</param>
        /// <returns>A Task representing the asynchronous operation, yielding the loaded asset.</returns>
        public static async Task<T> LoadBundleFromUrl<T>(string _uri, int _timeout, string _wannaLoadAssetsName,
            Hash128 _hash128, uint _crc, Action<float> _progressAction, Action<string> _failedAction)
            where T : Object
        {
            var tmp_FileName = Path.GetFileName(_uri).Split('?')[0];
            var tmp_CachedConfigure = new CachedAssetBundle {hash = _hash128};

            // If the asset bundle is already loaded, reload the asset from the existing bundle.
            if (AssetBundleCollection.TryGetValue(tmp_FileName, out AssetBundle tmp_LoadedAssetBundle))
            {
                tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName).GetAwaiter();
                var tmp_ReloadAsset = await tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                return tmp_ReloadAsset as T;
            }

#if !UNITY_EDITOR
            // Auto clean-up old assets only work in real-devices
            if (!Caching.IsVersionCached(_uri.ToString(), tmp_CachedConfigure.hash))
            {
                var tmp_OldAssetsbundleName = Path.GetFileNameWithoutExtension(_uri);
                var tmp_CachePath =
                    $"{Application.temporaryCachePath.Replace("Caches", "UnityCache")}/Shared/{tmp_OldAssetsbundleName}";
                if (Directory.Exists(tmp_CachePath))
                {
                    var tmp_AllCacheDirectories = Directory.GetDirectories(tmp_CachePath);
                    for (int tmp_DirectoryIdx = 0;
                         tmp_DirectoryIdx < tmp_AllCacheDirectories.Length;
                         tmp_DirectoryIdx++)
                    {
                        Hash128 tmp_Hash128 =
                            Hash128.Parse(Path.GetFileName(tmp_AllCacheDirectories[tmp_DirectoryIdx]));
                        bool tmp_IsClearCached =
                            Caching.ClearCachedVersion(tmp_OldAssetsbundleName, tmp_Hash128);
                        if (tmp_IsClearCached)
                        {
#if UNITY_EDITOR
                            Debug.Log($"{tmp_OldAssetsbundleName}->{tmp_Hash128} asset was cleaned.");
#endif
                        }
                    }
                }
            }
#endif

            var tmp_Progress = Progress.Create(_progressAction);
            var tmp_WebRequestAssetBundle =
                UnityWebRequestAssetBundle.GetAssetBundle(_uri, tmp_CachedConfigure, _crc);
            await tmp_WebRequestAssetBundle.SendWebRequest().ToUniTask(progress: tmp_Progress);

            try
            {
                AssetBundle tmp_AssetBundle = DownloadHandlerAssetBundle.GetContent(tmp_WebRequestAssetBundle);
                var tmp_LoadedAsset = await tmp_AssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                AddAssetBundleToGlobalManager(tmp_AssetBundle.name, tmp_AssetBundle);
                return tmp_LoadedAsset as T;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load asset failed: {tmp_Exception.Message}");
                _failedAction?.Invoke(tmp_Exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously loads a specific asset from a local asset bundle file.
        /// Supports progress reporting.
        /// </summary>
        /// <typeparam name="T">The type of the asset to load (must inherit from UnityEngine.Object).</typeparam>
        /// <param name="_path">The full path to the asset bundle file.</param>
        /// <param name="_wannaLoadAssetsName">The name of the asset to load from the bundle.</param>
        /// <param name="_progressAction">Callback invoked to report loading progress (0.0 to 1.0).</param>
        /// <param name="_failedAction">Callback invoked if asset loading fails, providing an error message.</param>
        /// <returns>A Task representing the asynchronous operation, yielding the loaded asset.</returns>
        public static async Task<T> LoadBundleFromLocal<T>(string _path, string _wannaLoadAssetsName,
            Action<float> _progressAction, Action<string> _failedAction)
            where T : Object
        {
            var tmp_FileName = Path.GetFileName(_path);

            // If the asset bundle is already loaded, reload the asset from the existing bundle.
            if (AssetBundleCollection.TryGetValue(tmp_FileName, out AssetBundle tmp_LoadedAssetBundle))
            {
                var tmp_Progress = Progress.Create(_progressAction);
                var tmp_ReloadAsset =
                    await tmp_LoadedAssetBundle.LoadAssetAsync(_wannaLoadAssetsName).ToUniTask(tmp_Progress);
                return tmp_ReloadAsset as T;
            }

            try
            {
                var tmp_Progress = Progress.Create(_progressAction);
                var tmp_AssetBundle = await AssetBundle.LoadFromFileAsync(_path).ToUniTask(tmp_Progress);
                AddAssetBundleToGlobalManager(tmp_AssetBundle.name, tmp_AssetBundle);
                var tmp_LoadedAsset = await tmp_AssetBundle.LoadAssetAsync(_wannaLoadAssetsName);
                return tmp_LoadedAsset as T;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load asset failed: {tmp_Exception.Message}");
                _failedAction?.Invoke(tmp_Exception.Message);
                throw;
            }
        }

        /// <summary>
        /// Asynchronously loads a scene from a local asset bundle.
        /// </summary>
        /// <param name="_path">The full path to the asset bundle file containing the scene.</param>
        /// <param name="_wannaLoadAssetsName">The name of the scene to load from the bundle.</param>
        /// <returns>A Task representing the asynchronous scene loading operation.</returns>
        public static async Task LoadSceneFromBundle(string _path, string _wannaLoadAssetsName)
        {
            var tmp_XRExperienceName = Path.GetFileName(_path);

            // If the asset bundle is already loaded, load the scene from the existing bundle.
            if (AssetBundleCollection.TryGetValue(tmp_XRExperienceName, out AssetBundle tmp_LoadedAssetBundle))
            {
                await LoadSceneUtility.LoadSceneAsync(tmp_LoadedAssetBundle, _wannaLoadAssetsName);
                return;
            }

            try
            {
                tmp_LoadedAssetBundle = await LoadBundleFromLocal(_path, Debug.LogError);
                AddAssetBundleToGlobalManager(tmp_LoadedAssetBundle.name, tmp_LoadedAssetBundle);
                await LoadSceneUtility.LoadSceneAsync(tmp_LoadedAssetBundle, _wannaLoadAssetsName);
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load {_wannaLoadAssetsName} scene failed: \n{tmp_Exception.Message}");
                throw;
            }
        }

        /// <summary>
        /// Releases all currently loaded asset bundles that end with "arexperience" and unloads unused assets from memory.
        /// </summary>
        public static void ReleaseAllAssetBundle()
        {
            var tmp_AllLoadedAssetBundles = AssetBundle.GetAllLoadedAssetBundles().ToList();
            foreach (AssetBundle tmp_LoadedAssetBundle in tmp_AllLoadedAssetBundles)
            {
                // Only unload asset bundles specific to "arexperience" to avoid affecting other bundles.
                var tmp_BundleSuffix = Path.GetExtension(tmp_LoadedAssetBundle.name);
                if (!_PACKAGE_NAMES.Contains(tmp_BundleSuffix)) continue;
                tmp_LoadedAssetBundle.Unload(true);
            }

            AssetBundleCollection.Clear();
            Resources.UnloadUnusedAssets();
        }

        /// <summary>
        /// Releases a specific loaded asset bundle and destroys associated GameObjects with a matching process ID.
        /// </summary>
        /// <param name="_bundleName">The name of the asset bundle to release.</param>
        /// <param name="_processId">The process ID used to identify and destroy related GameObjects.</param>
        /// <param name="_unloadAll">If true, all assets in the bundle are unloaded; otherwise, only the bundle itself is unloaded.</param>
        public static void ReleaseAssetBundle(string _bundleName, string _processId, bool _unloadAll = true)
        {
            var tmp_BundleSuffix = Path.GetExtension(_bundleName);
            if (!AssetBundleCollection.TryGetValue(_bundleName.ToLower(), out var tmp_Bundle)) return;
            if (!_PACKAGE_NAMES.Contains(tmp_BundleSuffix)) return;

            // Destroy GameObjects associated with the given process ID.
            var tmp_AllGoByCurrentProcess = Resources.FindObjectsOfTypeAll<ProcessIdComponent>().Where(_Pid =>
                _Pid.ProcessId == _processId
            );

            foreach (ProcessIdComponent tmp_ProcessId in tmp_AllGoByCurrentProcess)
            {
                if (!tmp_ProcessId || !tmp_ProcessId.gameObject) continue;
                Object.DestroyImmediate(tmp_ProcessId.gameObject, true);
            }

            if (_unloadAll)
            {
                tmp_Bundle.UnloadAsync(true).completed += _operation =>
                {
                    AssetBundleCollection.Remove(_bundleName.ToLower());
                };
            }
        }

        /// <summary>
        /// Releases a specific loaded scene asset bundle and destroys associated GameObjects with a matching process ID.
        /// </summary>
        /// <param name="_bundleName">The base name of the scene asset bundle to release (e.g., "myproject").</param>
        /// <param name="_processId">The process ID used to identify and destroy related GameObjects.</param>
        /// <param name="_unloadAll">If true, all assets in the bundle are unloaded; otherwise, only the bundle itself is unloaded.</param>
        public static void ReleaseAssetBundleScene(string _bundleName, string _processId, bool _unloadAll = true)
        {
            var tmp_BundleName = Path.GetFileNameWithoutExtension(_bundleName).ToLower();
            var tmp_BundleSuffix = Path.GetExtension(_bundleName).ToLower();
            var tmp_SceneBundleName = $"{tmp_BundleName}_Scene{tmp_BundleSuffix}";
            if (!AssetBundleCollection.TryGetValue(tmp_SceneBundleName, out var tmp_Bundle)) return;
            if (!_PACKAGE_NAMES.Contains(tmp_BundleSuffix)) return;


            // Destroy GameObjects associated with the given process ID.
            var tmp_AllGoByCurrentProcess = Resources.FindObjectsOfTypeAll<ProcessIdComponent>().Where(_Pid =>
                _Pid.ProcessId == _processId
            );

            foreach (ProcessIdComponent tmp_ProcessId in tmp_AllGoByCurrentProcess)
            {
                if (!tmp_ProcessId || !tmp_ProcessId.gameObject) continue;
                Object.DestroyImmediate(tmp_ProcessId.gameObject, true);
            }

            LoadSceneUtility.UnloadRuntimeScenes(tmp_Bundle);

            if (_unloadAll)
            {
                tmp_Bundle.UnloadAsync(true).completed += _operation =>
                {
                    AssetBundleCollection.Remove(tmp_SceneBundleName);
                };
            }
        }

        /// <summary>
        /// Adds a loaded AssetBundle to the global collection for tracking and management.
        /// </summary>
        /// <param name="_opHashCode">The key (typically the asset bundle name) for the collection.</param>
        /// <param name="_assetBundle">The loaded AssetBundle instance.</param>
        private static void AddAssetBundleToGlobalManager(string _opHashCode, AssetBundle _assetBundle)
        {
            AssetBundleCollection.TryAdd(_opHashCode, _assetBundle);
        }

        /// <summary>
        /// Asynchronously loads an AssetBundle from a local file path.
        /// </summary>
        /// <param name="_path">The full path to the asset bundle file.</param>
        /// <param name="_failedAction">Callback invoked if asset bundle loading fails, providing an error message.</param>
        /// <returns>A Task representing the asynchronous operation, yielding the loaded AssetBundle.</returns>
        private static async Task<AssetBundle> LoadBundleFromLocal(string _path, Action<string> _failedAction)
        {
            var tmp_FileName = Path.GetFileName(_path);

            // If the asset bundle is already loaded, return the existing instance.
            if (AssetBundleCollection.TryGetValue(tmp_FileName, out AssetBundle tmp_LoadedAssetBundle))
            {
                return tmp_LoadedAssetBundle;
            }

            try
            {
                var tmp_Bundle = await AssetBundle.LoadFromFileAsync(_path).ToUniTask();
                return tmp_Bundle;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError($"Load asset failed at {_path}.");
                _failedAction?.Invoke(tmp_Exception.Message);
                throw;
            }
        }
    }
}