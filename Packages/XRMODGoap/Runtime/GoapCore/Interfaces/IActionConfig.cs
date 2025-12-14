using System;
using Goap.Agent.Core;

namespace Goap.Core
{
    public interface IActionConfig : IClassConfig
    {
        float BaseCost { get; }
        ITargetKey Target { get; }
        float StoppingDistance { get; }
        bool ValidateTarget { get; }
        bool RequiresTarget { get; }
        bool ValidateConditions { get; }
        ICondition[] Conditions { get; }
        IEffect[] Effects { get; }
        public ActionMoveMode MoveMode { get; }
        public IActionProperties Properties { get; }
    }

    public interface IClassCallbackConfig
    {
        public Action<object> Callback { get; }
    }
}
