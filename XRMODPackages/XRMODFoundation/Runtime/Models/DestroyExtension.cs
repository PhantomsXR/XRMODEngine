// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Models.Runtime
{
    /// <summary>
    /// Extension methods for destroying Unity objects safely across different platforms and contexts (Editor vs Runtime).
    /// </summary>
    public static class DestroyExtension
    {
        /// <summary>
        /// Destroys a Unity object using <c>DestroyImmediate</c> in the Editor and <c>Destroy</c> at Runtime.
        /// </summary>
        /// <param name="_object">The object to destroy.</param>
        public static void DestroyWithPlatform(this UnityEngine.Object _object)
        {
            if (Application.isEditor)
            {
                Object.DestroyImmediate(_object, true);
            }
            else
            {
                Object.Destroy(_object);
            }
        }
    }
}