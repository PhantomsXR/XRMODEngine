// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The UnityRokidLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class GenericHaptic : MonoBehaviour
    {
        private void Awake()
        {
            Vibration.Init();
        }

        public void VibratePeek()
        {
#if UNITY_IOS
            Vibration.VibrateIOS(ImpactFeedbackStyle.Medium);
#else
            Vibration.VibratePeek();
#endif
        }

        public void VibratePop()
        {
#if UNITY_IOS
            Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
#else
            Vibration.VibratePop();
#endif
        }


        public async void VibrateAndroidDeviceOnly(int _cancelMilliseconds)
        {
#if UNITY_ANDROID
            Vibration.VibrateAndroid(500L);
            await Task.Delay(_cancelMilliseconds);
            Vibration.CancelAndroid();
#endif
        }
    }
}