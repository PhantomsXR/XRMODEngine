using System;
using Goap.Agent.Core;
using Goap.Core;

namespace Goap.Runtime
{
    public abstract class GoalBase : IGoal
    {
        public int Index { get; set; }
        public IGoalConfig Config { get; private set; }

        public Guid Guid { get; } = Guid.NewGuid();
        public IEffect[] Effects { get; } = { };

        public ICondition[] Conditions { get; private set; }

        public void SetConfig(IGoalConfig config)
        {
            this.Config = config;
            this.Conditions = config.Conditions.ToArray();
        }

        public virtual float GetCost(IActionReceiver agent, IComponentReference references)
        {
            return this.Config.BaseCost;
        }
    }
}
