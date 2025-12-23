/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Core.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Provides common C# Unity extensions for XRMOD.
    /// </summary>
    public static class Extentsions
    {
        /// <summary>
        /// Safely destroys a Unity Object. 
        /// Uses <see cref="Object.DestroyImmediate"/> in the Editor and <see cref="Object.Destroy"/> at runtime.
        /// </summary>
        /// <param name="_object">The object to destroy.</param>
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