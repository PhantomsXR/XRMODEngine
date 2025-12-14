// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Avatar.Runtime.
// //
// // The Avatar cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Avatar.Runtime
{
    [System.Serializable]
    public struct SerializablePose
    {
        public Vector3 position;
        public Quaternion rotation;

        public SerializablePose(Pose pose)
        {
            position = pose.position;
            rotation = pose.rotation;
        }

        public Pose ToPose()
        {
            return new Pose(position, rotation);
        }
    }
}