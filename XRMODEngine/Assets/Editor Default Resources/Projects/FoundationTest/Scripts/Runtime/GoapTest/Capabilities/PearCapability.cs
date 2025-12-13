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
    public class PearCapability : CapabilityFactoryBase
    {
        public override ICapabilityConfig Create()
        {
            var tmp_Builder = new CapabilityBuilder("PearCapability");


            tmp_Builder.AddGoal<PickupPearGoal>()
                .AddCondition<PearCount>(Comparison.GreaterThanOrEqual, 3);

            tmp_Builder.AddAction<PickupPearAction>()
                .AddEffect<PearCount>(EffectType.Increase)
                .SetTarget<ClosestPear>();

            tmp_Builder.AddMultiSensor<PearSensor>();
         
            return tmp_Builder.Build();
        }
    }
}