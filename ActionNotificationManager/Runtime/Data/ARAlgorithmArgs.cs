// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public enum ARAlgorithmType
    {
        Anchor = 1,
#if HANDHELD_AR_INSTALL
        FocusSLAM = 2,
#endif
        ImageTracker = 3,
        Immersal = 4,

#if HANDHELD_AR_INSTALL
        FaceMesh = 5,
        //2.0.0-pre.2
        ARBackground = 6,
        Basic = 7,
#endif
        Meshing = 8,
#if HANDHELD_AR_INSTALL
        Stereo = 9,
#endif
#if QUEST_INSTALL || PICO_INSTALL
        PassThrough = 10,
#endif
        Occlusion = 11,
        Raycasts = 12,

#if QUEST_INSTALL
        BoundingBoxes = 13,
#endif
    }

    public enum ARAlgorithmOperator
    {
        StartAlgorithm,
        PauseAlgorithm,
        StopAlgorithm
    }

    public class ARAlgorithmArgs : BaseNotificationData
    {
        public ARAlgorithmType ARAlgorithmType;
        public ARAlgorithmOperator ARAlgorithmOperator;
        public bool Mixed;
    }
}