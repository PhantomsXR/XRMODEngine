/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.PackageTools.Editor.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System.Collections.Generic;
using System.IO;
using Phantom.XRMOD.XRMODPackageTools.Editor.Previewers;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ExperienceInspectorController
    {
        private AssetBundle _currentBundle;
        private IAssetPreview _currentPreview;
        private readonly List<string> _assetPathList = new();

        public List<string> AssetPathList => _assetPathList;

        public bool LoadBundle(string path)
        {
            UnloadBundle();

            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                Debug.LogError("Invalid path.");
                return false;
            }

            _currentBundle = AssetBundle.LoadFromFile(path);
            if (_currentBundle == null)
            {
                Debug.LogError("Failed to load AssetBundle.");
                return false;
            }

            _assetPathList.Clear();
            _assetPathList.AddRange(_currentBundle.GetAllAssetNames());
            return true;
        }

        public void UnloadBundle()
        {
            if (_currentBundle != null)
            {
                _currentBundle.Unload(true);
                _currentBundle = null;
            }
            _assetPathList.Clear();
            CleanupPreview();
        }

        public void ShowPreview(string assetPath, VisualElement container)
        {
            CleanupPreview();
            container.Clear();

            if (_currentBundle == null) return;

            var asset = _currentBundle.LoadAsset(assetPath);
            if (asset == null) return;

            _currentPreview = AssetPreviewFactory.CreatePreview(asset);
            if (_currentPreview != null)
            {
                _currentPreview.DrawPreview(container, asset);
            }
            else
            {
                // Fallback for unknown or simple types
                var label = new Label($"Type: {asset.GetType().Name}\nName: {asset.name}");
                label.AddToClassList("preview-label");
                container.Add(label);
            }
        }

        private void CleanupPreview()
        {
            if (_currentPreview != null)
            {
                _currentPreview.Cleanup();
                _currentPreview = null;
            }
        }
    }
}
