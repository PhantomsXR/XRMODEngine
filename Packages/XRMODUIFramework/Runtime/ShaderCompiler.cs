// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public static class ShaderCompiler
    {
        [RuntimeInitializeOnLoadMethod]
        static void CompilingShaders()
        {
            var tmp_ShaderVariant = Resources.Load<ShaderVariantCollection>("XRMODUIFrameworkShaderCollection");
            if (tmp_ShaderVariant != null)
                tmp_ShaderVariant.WarmUp();
        }
    }
}