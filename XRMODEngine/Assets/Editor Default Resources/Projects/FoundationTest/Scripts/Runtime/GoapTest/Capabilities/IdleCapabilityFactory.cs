using Goap.Core;
using Goap.Runtime; 

namespace FoundationTest.Runtime
{
    public class IdleCapabilityFactory : CapabilityFactoryBase
    {
        public override ICapabilityConfig Create()
        {
            var tmp_Builder = new CapabilityBuilder("IdleCapability");

            tmp_Builder.AddGoal<IdleGoal>()
                .AddCondition<IsIdle>(Comparison.GreaterThanOrEqual, 1)
                .SetBaseCost(2);

            tmp_Builder.AddAction<IdleAction>()
                .AddEffect<IsIdle>(EffectType.Increase)
                .SetTarget<IdleTarget>();
            
            tmp_Builder.AddTargetSensor<IdleTargetSensor>()
                .SetTarget<IdleTarget>();

            return tmp_Builder.Build();
        }
    }
}