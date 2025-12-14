// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Core.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    public static class Extentsions
    {
        public static void SafeDestroy(this Object _object)
        {
#if UNITY_EDITOR
            Object.DestroyImmediate(_object);
#else
            Object.Destroy(_object);
#endif
        }
    }
}