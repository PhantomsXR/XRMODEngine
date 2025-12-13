// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/


using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime.Attribute;
using Phantom.XRMOD.XRMODInput.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    [System.Serializable]
    public class CustomDataPropertyTest
    {
        public int Id;
        public string Name;
        public int Score;
        public Vector3 P;
        public Quaternion r;
        public List<Vector3> Position = new List<Vector3>();
        public Vector3[] Vector3Array;
        public Quaternion[] Quaternions;
        public Rect[] Rects;
        public Color[] Colors;
        public Rect Rect;
        public float Float;
    }
    
    
    [System.Serializable]
    public class HammerPose
    {
        public InputType InputType;
        public Vector3 HammerPosition;
        public Vector3 HammerRotation;
    }
}