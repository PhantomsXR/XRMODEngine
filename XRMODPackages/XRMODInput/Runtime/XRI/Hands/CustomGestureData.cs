// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The UnityXR-MODLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI && XR_HANDS_1_1_OR_NEWER

using System;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    [System.Serializable]
    public class CustomGestureData
    {
        public ScriptableObject GestureHandOrPose;
        public float MinimumHoldTime = .2f;
        public float GestureDetectionInterval = .1f;
        public UnityAction OnPerformed;
        public UnityAction OnEnded;
    }
}

#endif