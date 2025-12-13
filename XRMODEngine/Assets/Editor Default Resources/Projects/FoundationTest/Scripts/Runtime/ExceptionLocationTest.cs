// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class ExceptionLocationTest : XRMODBehaviour
    {
        public GameObject EmptyGo;
        public float FloatValue;
        public int IntValue;
        public bool BoolValue;
        public string StringValue;
        public Vector2 Vector2Value;
        public Vector3 Vector3Value;
        public Vector4 Vector4Value;
        public Quaternion QuaternionValue;
        public Color ColorValue;
        public LayerMask LayerMaskValue;
        public AnimationCurve CurveValue;

        public Transform TransformValue;

        public Transform[] TransformArrayValue;
        public GameObject[] GameObjectArrayValue;
        public Vector2[] Vector2ArrayValue;
        public Vector3[] Vector3ArrayValue;
        public Vector4[] Vector4ArrayValue;
        public Quaternion[] QuaternionArrayValue;
        public Color[] ColorArrayValue;
        public Animator[] AnimatorArrayValue;
        public AnimationCurve[] AnimationCurveValue;
        public float[] FloatArrayValue;
        public string[] StringArrayValue;


        private void Start()
        {
            Assert.IsNull(EmptyGo);
            Debug.Log($"<color=green>{nameof(ExceptionLocationTest)} Test passed!</color>");
        }
    }
}