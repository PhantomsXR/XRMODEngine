// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine.XR.OpenXR.Features;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Contains static callbacks for P/Invoke calls from the Rokid native SDK.
    /// Handles camera data updates and marshaling to managed code.
    /// </summary>
    public static class RokidNativeMonoPInvokeCallbacks
    {
        internal static Action<byte[], ushort, ushort, long> FrameUpdateCallback;


        /// <summary>
        /// Callback method for receiving camera data from native code.
        /// Marshals byte data and dispatches the update to the main thread.
        /// </summary>
        /// <param name="_ptr">Pointer to the camera image data.</param>
        /// <param name="_size">Size of the data in bytes.</param>
        /// <param name="_width">Image width.</param>
        /// <param name="_height">Image height.</param>
        /// <param name="_timestamp">Capture timestamp.</param>
        [MonoPInvokeCallback(typeof(RokidExtensionAPI.OnCameraDataUpdateC))]
        internal static void OnCameraDataUpdateCallWithImage(IntPtr _ptr, int _size, ushort _width, ushort _height,
            long _timestamp)
        {
            byte[] tmp_Data = new byte[_size];
            Marshal.Copy(_ptr, tmp_Data, 0, _size);
            Loom.QueueOnMainThread(() => { FrameUpdateCallback?.Invoke(tmp_Data, _width, _height, _timestamp); });
        }
    }
}