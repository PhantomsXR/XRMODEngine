// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class ReleaseDllLoaderProvider : IDllLoaderProvider
    {
        public async Task LoadAssembly(AppDomain _appDomain, string _projectName)
        {
            var tmp_DllBytes =
                await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(_projectName,
                    $"{_projectName.ToLower()}.runtime.dll");
            SharedData.Instance.dllStream = new MemoryStream(tmp_DllBytes.bytes); 
            _appDomain.LoadAssembly(SharedData.Instance.dllStream, null,
                new global::UnityFusion.Mono.Cecil.Pdb.PdbReaderProvider());
            _appDomain.DebugService.StartDebugService(56000);
        }
    }
}