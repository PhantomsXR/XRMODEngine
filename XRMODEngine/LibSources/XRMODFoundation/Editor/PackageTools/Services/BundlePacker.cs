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
using System.Diagnostics;
using System.IO;
using System.Linq;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEditor;
using UnityEditor.Build.Pipeline;
using UnityEditor.Build.Pipeline.Interfaces;
using UnityEngine;
using BundleDetails = UnityEngine.Build.Pipeline.BundleDetails;
using Debug = UnityEngine.Debug;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public static class BundlePacker
    {
        private static readonly XRExperienceData _AR_EXPERIENCE_DETAIL = new();

        // ReSharper disable once IdentifierTypo
        public static ReturnCode ScriptableBuildPipeline(
            string _bundleName,
            List<string> _addressableNames,
            List<string> _assetNames,
            BuildTarget _buildTarget,
            BuildTargetGroup _buildTargetGroup,
            BuildCompression _buildCompression,
            string _outPath)
        {
            var tmp_BuildTimer = new Stopwatch();
            tmp_BuildTimer.Start();

            var tmp_DuplicateElements = _assetNames.GroupBy(_x => _x)
                .Where(_g => _g.Count() > 1)
                .Select(_g => _g.Key).ToArray();

            if (tmp_DuplicateElements.Length > 0)
            {
                foreach (string tmp_DuplicateElement in tmp_DuplicateElements)
                {
                    Debug.Log($"Duplicate asset in list:{tmp_DuplicateElement}. It will ignore.");
                }
            }

            _assetNames = _assetNames.Distinct().ToList();
            var tmp_BuildContent = GetBundleContent(_bundleName, _addressableNames, _assetNames);
            var tmp_BuildParams = new BundleBuildParameters(_buildTarget, _buildTargetGroup, _outPath)
            {
                BundleCompression = _buildCompression
            };

            ReturnCode tmp_ReturnCode = ContentPipeline.BuildAssetBundles(tmp_BuildParams, tmp_BuildContent,
                out IBundleBuildResults tmp_Result);

            tmp_BuildTimer.Stop();

            if (tmp_ReturnCode == ReturnCode.Success)
            {
                _AR_EXPERIENCE_DETAIL.BundleName = _bundleName;
                _AR_EXPERIENCE_DETAIL.AssetsName = _assetNames;
                _AR_EXPERIENCE_DETAIL.AddressableName = _addressableNames;


                var tmp_JsonSavedPath = Path.Combine(_outPath, $"{_bundleName}.{ConstKey.CONST_ASSET_INFO_SUFFIX}");

                foreach (KeyValuePair<string, BundleDetails> tmp_Detail in tmp_Result.BundleInfos)
                {
                    _AR_EXPERIENCE_DETAIL.BundleDetails = tmp_Detail.Value;
                    break;
                }


                if (_AR_EXPERIENCE_DETAIL.PackMode == XRExperienceData.PackModeType.AssetAndScene)
                {
                    var tmp_FilesPath = Directory.GetFiles(_outPath, "*.arexperience", SearchOption.AllDirectories);
                    var tmp_CompressingFolderName = _outPath.Split("/")[^1];
                    var tmp_OutPath = Path.Combine(_outPath, $"{tmp_CompressingFolderName}.package");
                    ZipFileUtility.ZipFiles(tmp_FilesPath, tmp_OutPath,
                        Utility.CalculateMD5Hash(tmp_CompressingFolderName));
                    foreach (string tmp_FilePath in tmp_FilesPath)
                    {
                        if (File.Exists(tmp_FilePath))
                            File.Delete(tmp_FilePath);
                    }
                }

                File.WriteAllText(tmp_JsonSavedPath, EditorJsonUtility.ToJson(_AR_EXPERIENCE_DETAIL));
                Debug.Log($"Packed Success,Consumed {tmp_BuildTimer.Elapsed} ms");
                File.Delete(Path.Combine(_outPath, "buildlogtep.json"));
            }

            AssetDatabase.Refresh();


            _AR_EXPERIENCE_DETAIL.CleanUp();
            return tmp_ReturnCode;
        }


        static IBundleBuildContent GetBundleContent(string _bundleName, List<string> _addressableNames,
            List<string> _assetNames)
        {
            List<AssetBundleBuild> tmp_BuildDataList = new List<AssetBundleBuild>();


            var tmp_AssetNamesWithoutScene =
                _assetNames.Where(_assetName => !_assetName.EndsWith("unity")).ToArray();
            var tmp_AddressableNamesWithoutScene =
                _addressableNames.Where(_addressableName => !_addressableName.EndsWith("unity")).ToArray();


            var tmp_AssetNamesWithScene =
                _assetNames.Where(_assetName => _assetName.EndsWith(".unity")).ToArray();
            var tmp_AddressableNamesWithScene =
                _addressableNames.Where(_addressableName => _addressableName.EndsWith(".unity")).ToArray();

            var tmp_HasGenericAsset =
                tmp_AssetNamesWithoutScene.Length > 0 && tmp_AddressableNamesWithoutScene.Length > 0;
            if (tmp_HasGenericAsset)
            {
                AssetBundleBuild tmp_Data = new AssetBundleBuild()
                {
                    addressableNames = tmp_AddressableNamesWithoutScene,
                    assetBundleName = $"{_bundleName}.{ConstKey.CONST_ASSET_SUFFIX}",
                    assetBundleVariant = "",
                    assetNames = tmp_AssetNamesWithoutScene,
                };
                tmp_BuildDataList.Add(tmp_Data);
                _AR_EXPERIENCE_DETAIL.PackMode = XRExperienceData.PackModeType.AssetOnly;
            }

            var tmp_HasSceneAsset = tmp_AddressableNamesWithScene.Length > 0 && tmp_AssetNamesWithScene.Length > 0;
            if (tmp_HasSceneAsset)
            {
                AssetBundleBuild tmp_SceneData = new AssetBundleBuild()
                {
                    addressableNames = tmp_AddressableNamesWithScene,
                    assetBundleName = $"{_bundleName}_Scene.{ConstKey.CONST_ASSET_SUFFIX}",
                    assetBundleVariant = "",
                    assetNames = tmp_AssetNamesWithScene,
                };
                tmp_BuildDataList.Add(tmp_SceneData);
            }

            if (tmp_HasSceneAsset && tmp_HasGenericAsset)
                _AR_EXPERIENCE_DETAIL.PackMode = XRExperienceData.PackModeType.AssetAndScene;

            IBundleBuildContent tmp_BuildContent = new BundleBuildContent(tmp_BuildDataList);
            return tmp_BuildContent;
        }
    }
}