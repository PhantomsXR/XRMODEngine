using Goap.Core;

namespace Goap.Runtime
{
    public class ConditionObserver : ConditionObserverBase
    {
        public override bool IsMet(ICondition condition)
        {
            return this.WorldData.IsTrue(condition.WorldKey, condition.Comparison, condition.Amount);
        }
    }
}