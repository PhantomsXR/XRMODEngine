// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Goap.Core;
using Goap.Runtime;

namespace FoundationTest.Runtime
{
    public class EatCapability : CapabilityFactoryBase
    {
        public override ICapabilityConfig Create()
        {
            var tmp_Builder = new CapabilityBuilder("EatCapability");

            tmp_Builder.AddGoal<EatGoal>()
                .AddCondition<Hunger>(Comparison.SmallerThanOrEqual, 0);

            tmp_Builder.AddAction<EatAction>()
                .AddEffect<Hunger>(EffectType.Decrease)
                .AddCondition<PearCount>(Comparison.GreaterThanOrEqual, 1)
                .SetRequiresTarget(false);

            return tmp_Builder.Build();
        }
    }
}