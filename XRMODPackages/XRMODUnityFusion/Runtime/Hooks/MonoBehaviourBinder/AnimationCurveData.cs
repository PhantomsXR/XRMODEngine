// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    /// <summary>
    /// Represents a serializable version of the Unity <see cref="AnimationCurve"/>.
    /// This is used to store curve data in a way that can be easily serialized (e.g., to JSON).
    /// </summary>
    [System.Serializable]
    public class AnimationCurveData
    {
        public KeyframeData[] keys;
        public WrapMode preWrapMode;
        public WrapMode postWrapMode;

        /// <summary>
        /// Represents the data for a single keyframe in the animation curve.
        /// </summary>
        [System.Serializable]
        public class KeyframeData
        {
            /// <summary> The time of the keyframe. </summary>
            public float time;
            /// <summary> The value of the curve at this time. </summary>
            public float value;
            /// <summary> The incoming tangent. </summary>
            public float inTangent;
            /// <summary> The outgoing tangent. </summary>
            public float outTangent;
            /// <summary> The tangent mode (auto, linear, constant, etc.). </summary>
            public int tangentMode;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="AnimationCurveData"/> from a Unity <see cref="AnimationCurve"/>.
        /// </summary>
        /// <param name="_curve">The source Unity animation curve.</param>
        public AnimationCurveData(AnimationCurve _curve)
        {
            keys = new KeyframeData[_curve.keys.Length];
            for (int tmp_I = 0; tmp_I < _curve.keys.Length; tmp_I++)
            {
                var tmp_Key = _curve.keys[tmp_I];
                keys[tmp_I] = new KeyframeData
                {
                    time = tmp_Key.time,
                    value = tmp_Key.value,
                    inTangent = tmp_Key.inTangent,
                    outTangent = tmp_Key.outTangent,
                    tangentMode = tmp_Key.tangentMode
                };
            }

            preWrapMode = _curve.preWrapMode;
            postWrapMode = _curve.postWrapMode;
        }
    }

    /// <summary>
    /// Extension methods for serializing and deserializing animation curves.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Serializes an <see cref="AnimationCurve"/> into a JSON string.
        /// </summary>
        /// <param name="_curve">The curve to serialize.</param>
        /// <returns>A JSON string representation of the curve.</returns>
        public static string SerializeAnimationCurve(this AnimationCurve _curve)
        {
            AnimationCurveData tmp_CurveData = new AnimationCurveData(_curve);
            return JsonUtility.ToJson(tmp_CurveData);
        }
        
        /// <summary>
        /// Deserializes a JSON string into an <see cref="AnimationCurve"/>.
        /// </summary>
        /// <param name="_json">The JSON string representing the curve.</param>
        /// <returns>A new <see cref="AnimationCurve"/> instance.</returns>
        public static AnimationCurve DeserializeAnimationCurve(this string _json)
        {
            AnimationCurveData tmp_CurveData = JsonUtility.FromJson<AnimationCurveData>(_json);
            Keyframe[] tmp_Keys = new Keyframe[tmp_CurveData.keys.Length];
            for (int tmp_I = 0; tmp_I < tmp_CurveData.keys.Length; tmp_I++)
            {
                var tmp_KeyData = tmp_CurveData.keys[tmp_I];
                tmp_Keys[tmp_I] = new Keyframe(
                    tmp_KeyData.time,
                    tmp_KeyData.value,
                    tmp_KeyData.inTangent,
                    tmp_KeyData.outTangent
                );
                tmp_Keys[tmp_I].tangentMode = tmp_KeyData.tangentMode;
            }
            AnimationCurve tmp_Curve = new AnimationCurve(tmp_Keys)
            {
                preWrapMode = tmp_CurveData.preWrapMode,
                postWrapMode = tmp_CurveData.postWrapMode
            };
            return tmp_Curve;
        }

    }
}