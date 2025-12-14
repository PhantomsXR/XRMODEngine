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
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class SharedData
    {
        private static SharedData sharedData;
        public static SharedData Instance=> sharedData ??= new SharedData();
        
        
        internal MemoryStream dllStream;
        internal MemoryStream symbolStream;
        internal AppDomain appDomain;
    }
}