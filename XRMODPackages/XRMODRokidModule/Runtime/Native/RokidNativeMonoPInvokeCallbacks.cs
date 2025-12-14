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
    public static class RokidNativeMonoPInvokeCallbacks
    {
        internal static Action<byte[], ushort, ushort, long> FrameUpdateCallback;


        // 使用MonoPInvokeCallback特性来指定这个函数是由C代码通过P/Invoke调用的，  
        // 它的签名需要与C代码中的函数指针类型RokidExtensionAPI.OnCameraDataUpdateC相匹配  
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