// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ProcessShareData : IDisposable
    {
        private static ProcessShareData _PROCESS_SHARE_DATA;
        internal static ProcessShareData GetInstance => _PROCESS_SHARE_DATA ??= new ProcessShareData();

        internal string projectName;
        internal string autoGenerationPath;
        internal string projectPath;
        internal string saveBundlePath;

        internal BuildCompression buildCompression;

        public ProjectDetailCacheData projectDetailCacheData;
        internal List<string> addressableName { get; private set; } = new List<string>();
        internal List<string> bundlePath { get; private set; } = new List<string>();
        internal List<string> tempAssetsPath { get; private set; } = new List<string>();

        private ProcessShareData()
        {
        }

        public void Dispose()
        {
            projectName = null;
            projectPath = null;
            autoGenerationPath = null;
            saveBundlePath = null;
            projectDetailCacheData = null;
            addressableName.Clear();
            bundlePath.Clear();
            tempAssetsPath.Clear();
        }
    }
}