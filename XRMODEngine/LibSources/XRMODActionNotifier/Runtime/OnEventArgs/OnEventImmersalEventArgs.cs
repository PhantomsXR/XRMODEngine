// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    [System.Serializable]
    public struct LocalizerPose
    {
        public bool valid;
        public double[] mapToEcef;
        public Matrix4x4 matrix;
        public Pose lastUpdatedPose;
        public double vLatitude;
        public double vLongitude;
        public double vAltitude;
    }


    public class OnEventImmersalEventArgs : BaseNotificationData
    {
        public int MapId;
        public LocalizerPose LocalizerPose;
        public ImmersalEventTypes ImmersalEventType;
        public enum ImmersalEventTypes
        {
            OnFirstLocalization,
            OnLocalizerPoseFound,
            OnPoseLose,
            OnPoseFound,
            OnMapChanged,
            OnReset
        }
    }
}