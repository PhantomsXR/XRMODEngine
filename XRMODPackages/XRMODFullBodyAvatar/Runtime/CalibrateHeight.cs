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

using RootMotion.FinalIK;
using UnityEngine;

namespace Phantom.XRMOD.Avatar.Runtime
{
    public class CalibrateHeight
    {
        private const float _CONST_MAX_ALLOWED_HEIGHT = 2.2f;
        private const float _CONST_MIN_ALLOWED_HEIGHT = 1.35f;
        private float lastCalibratedHeight;
        private float scale;
        private float avatarDefaultHeight = 1.36f;
        private VRIK ik;

        public CalibrateHeight(VRIK _ik)
        {
            ik = _ik;
        }

        public void StartCalibrateHeight()
        {
            lastCalibratedHeight =
                Mathf.Min(_CONST_MAX_ALLOWED_HEIGHT,
                    Mathf.Max(_CONST_MIN_ALLOWED_HEIGHT, Camera.main.transform.position.y));
            CalibrateBody();
        }

        public void CalibrateBody()
        {
            scale = lastCalibratedHeight / avatarDefaultHeight;
            // Scale the avatar game object via VRIK
            ik.references.root.localScale = new Vector3(scale, scale, scale);
            CalibrateHead();
            CalibrateHands();
        }

        // Calibrate the avatar head to the correct size (a bigger avatar 
        // has a slightly smaller head and vice versa).
        private void CalibrateHead()
        {
            const float tmp_const_ScaleDivisionConstant = 2f;
            var headScale = 1f + (1f - scale) / tmp_const_ScaleDivisionConstant;
            ik.references.head.localScale = new Vector3(headScale, headScale, headScale);
        }

        // This method calibrates avatar hands back to one. This means, that the interactions
        // with hands don't need to change, since the hands are bigger/smaller.
        private void CalibrateHands()
        {
            ScaleBoneToOne(ik.references.leftHand);
            ScaleBoneToOne(ik.references.rightHand);
        }

        private void ScaleBoneToOne(Transform hand)
        {
            hand.localScale = Vector3.one;
            var lossyScale = hand.lossyScale;
            hand.localScale = new Vector3(1f / lossyScale.x,
                1f / lossyScale.y, 1f / lossyScale.z);
        }
    }
}