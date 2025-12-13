// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.ActionNotification.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine; 

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    /// <summary>
    /// Current experience space type
    /// </summary>
    public enum SpaceType : byte
    {
        SharedSpace,
        ExclusiveSpace,
        Metal,
        CustomProfile
    }

    public enum BoundResizeMode
    {
        None,

        [Tooltip("Resize the volume camera, scaling the content so it fits fully in the output window")]
        ScaleToFit,

        [Tooltip("Resize the volume camera to match the output window")]
        MatchWindowSize,
    }

    public class SpaceTypeActionArgs : ProcessesArgs
    {
        public SpaceType SpaceTypeValue;
        public BoundResizeMode BoundResizeMode = BoundResizeMode.None;
        public Vector3? Dimensions;
        public Vector3? BoundPosition;
        public LayerMask? CullingMask;  public bool MRPassthrough = false;
    }
}