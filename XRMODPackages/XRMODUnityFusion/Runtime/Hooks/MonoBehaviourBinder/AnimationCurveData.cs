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
    [System.Serializable]
    public class AnimationCurveData
    {
        public KeyframeData[] keys;
        public WrapMode preWrapMode;
        public WrapMode postWrapMode;

        [System.Serializable]
        public class KeyframeData
        {
            public float time;
            public float value;
            public float inTangent;
            public float outTangent;
            public int tangentMode;
        }

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

    public static class Extensions
    {
        public static string SerializeAnimationCurve(this AnimationCurve _curve)
        {
            AnimationCurveData tmp_CurveData = new AnimationCurveData(_curve);
            return JsonUtility.ToJson(tmp_CurveData);
        }
        
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