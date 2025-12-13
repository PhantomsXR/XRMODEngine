// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.OpenXRModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.XR.OpenXR;

namespace Phantom.XRMOD.OpenXRMOD.Runtime
{
#if QUEST_INSTALL || UNITY_OPENXR || ANDROID_XR
    public class XRPlatformUnderstanding
    {
        private const string _CONST_RUNTIME_NAME_META = "Oculus";
        private const string _CONST_RUNTIME_NAME_ANDROID = "Android XR";

        /// <summary>
        /// The current platform based on the active XRSessionSubsystem.
        /// </summary>
        public static XRPlatformType CurrentPlatform
        {
            get
            {
                if (_INITIALIZED) return _CURRENT_PLATFORM;
                _CURRENT_PLATFORM = GetCurrentXRPlatform();
                _INITIALIZED = true;

                return _CURRENT_PLATFORM;
            }
        }

        private static XRPlatformType _CURRENT_PLATFORM = XRPlatformType.All;

        private static bool _INITIALIZED;

        /// <summary>
        /// Returns the current platform based on the active OpenXR Runtime Name.
        /// </summary>
        /// <returns>The current platform based on the active OpenXR Runtime Name.</returns>
        static XRPlatformType GetCurrentXRPlatform()
        {
            // If we have already initialized, just return the current platform
            if (_INITIALIZED)
                return _CURRENT_PLATFORM;

            var tmp_OpenXRRuntimeName = OpenXRRuntime.name;
            switch (tmp_OpenXRRuntimeName)
            {
                case _CONST_RUNTIME_NAME_META:
                    Debug.Log("Meta runtime detected.");
                    _CURRENT_PLATFORM = XRPlatformType.Quest;
                    break;
                case _CONST_RUNTIME_NAME_ANDROID:
                    Debug.Log("Android XR runtime detected.");
                    _CURRENT_PLATFORM = XRPlatformType.AndroidXR;
                    break;
                default:
                    Debug.Log($"Unknown OpenXR runtime detected: {tmp_OpenXRRuntimeName}");
                    _CURRENT_PLATFORM = XRPlatformType.Other;
                    break;
            }

            _INITIALIZED = true;
            return _CURRENT_PLATFORM;
        }
    }
#endif
}