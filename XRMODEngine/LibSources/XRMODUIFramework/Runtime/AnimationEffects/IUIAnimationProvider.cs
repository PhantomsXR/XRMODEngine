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

namespace Phantom.XRMOD.UIFramework.Runtime.AnimationEffects
{
    public interface IUIAnimationProvider
    {
        void Initialize(RectTransform _rect, CanvasGroup _canvasGroup, Vector3 _baseScale);
        void Play(float _duration, AnimationCurve _curve);
        bool Update(float _deltaTime);
    }
}