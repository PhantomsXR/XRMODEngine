// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public class PopInAnimation : MonoBehaviour
    {
        public AnimationCurve scaleCurve = new AnimationCurve(
            new Keyframe(0f, 0.3f, 0f, 3f), // 开始时很小
            new Keyframe(0.3f, 1.2f, 0f, -2f), // 快速放大到 1.2 倍
            new Keyframe(0.5f, 1.0f, -1f, 0f) // 回落到正常大小
        );

        public float duration = 0.5f;

        private float timer;
        private Vector3 baseScale;

        void Start()
        {
            baseScale = transform.localScale;
            timer = 0f;
        }

        void Update()
        {
            if (!(timer < duration)) return;
            timer += Time.deltaTime;
            float tmp_T = Mathf.Clamp01(timer / duration);
            float tmp_Scale = scaleCurve.Evaluate(tmp_T);
            transform.localScale = baseScale * tmp_Scale;
        }
    }
}