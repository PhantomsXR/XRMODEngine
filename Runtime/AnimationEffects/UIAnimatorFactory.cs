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

namespace Phantom.XRMOD.UIFramework.Runtime.AnimationEffects
{
    public static class UIAnimatorFactory
    {
        internal static IUIAnimationProvider CreateStrategy(UIAnimationType _animationType)
        {
            switch (_animationType)
            {
                case UIAnimationType.ScalePop: return new ScalePopAnimation();
                case UIAnimationType.FadeInScale: return new FadeInScaleAnimation();
                case UIAnimationType.Pulse: return new PulseAnimation();
                case UIAnimationType.FadeIn: return new FadeInAnimation();
                case UIAnimationType.SpringPop: return new SpringPopAnimation();
                case UIAnimationType.EmphasizedPop: return new EmphasizedPopAnimation();
                case UIAnimationType.LiftOnFocus: return new LiftOnFocusAnimation();
                case UIAnimationType.DimDissolve: return new DimDissolveAnimation();
                default: return new SpringPopAnimation();
            }
        }
    }
}