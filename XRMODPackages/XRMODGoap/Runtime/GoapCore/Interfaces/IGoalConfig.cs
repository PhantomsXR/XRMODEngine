using System.Collections.Generic;

namespace Goap.Core
{
    public interface IGoalConfig : IClassConfig
    {
        float BaseCost { get; set; }
        List<ICondition> Conditions { get; }
    }
}