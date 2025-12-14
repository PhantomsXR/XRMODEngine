// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    internal static class DestroyHelper
    {
        internal static void Destroy(Object @object)
        {
#if UNITY_EDITOR
            if (Application.isPlaying)
            {
                Object.Destroy(@object);
            }
            else
            {
                Object.DestroyImmediate(@object);
            }
#else
			Object.Destroy(@object);
#endif
        }
    }
}