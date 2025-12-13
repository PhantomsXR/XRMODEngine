// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODAPI.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    [Obsolete("Obsoleted", true)]
    public abstract class RuntimePlatformCheckerProvider
    {
        public abstract bool IsPlatform(PlatformType _platform);
    }

    public enum PlatformType : byte
    {
        Pico,
        Pico3,
        Pico4,
        Pico4p,
        Pico4u,

        QuestPro,
        Quest2,
        Quest3,
        Quest3s,

        VisionOS,
        VisionOS_1_X,
        VisionOS_2_X,

        RokidLite,
        RokidStudio,

        HandheldARiOS,
        HandheldARAndroid,

        Web,
        WebAR,
        WebVR,
        WebXR,

        XReal,

        Classic3DOSX,
        Classic3DiOS,
        Classic3DLinux,
        Classic3DWindows,
        Classic3DAndroid,
        DedicatedServerOSX,
        DedicatedServerWin,
        DedicatedServerLinux,
        Unknow
    }

   
}