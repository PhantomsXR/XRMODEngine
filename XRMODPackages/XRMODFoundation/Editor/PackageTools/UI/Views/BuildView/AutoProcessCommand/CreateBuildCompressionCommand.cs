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

using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class CreateBuildCompressionCommand : ProcessHandler
    {
        public override async Task Execute()
        {
            switch (ProcessShareData.GetInstance.projectDetailCacheData.BuildSettingData.BuildCompression)
            {
                case BuildCompressionType.Uncompressed:
                    ProcessShareData.GetInstance.buildCompression = BuildCompression.Uncompressed;
                    break;
                case BuildCompressionType.LZ4:
                    ProcessShareData.GetInstance.buildCompression = BuildCompression.LZ4;
                    break;
                case BuildCompressionType.LZMA:
                    ProcessShareData.GetInstance.buildCompression = BuildCompression.LZMA;
                    break;
                case BuildCompressionType.UncompressedRuntime:
                    ProcessShareData.GetInstance.buildCompression = BuildCompression.UncompressedRuntime;
                    break;
                case BuildCompressionType.LZ4Runtime:
                    ProcessShareData.GetInstance.buildCompression = BuildCompression.LZ4Runtime;
                    break;
            }

            await base.Execute();
        }
    }
}