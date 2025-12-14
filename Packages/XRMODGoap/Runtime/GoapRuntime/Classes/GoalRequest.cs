using System.Collections.Generic;
using Goap.Core;

namespace Goap.Runtime
{
    public class GoalRequest : IGoalRequest
    {
        public List<IGoal> Goals { get; set; } = new();
        public string Key { get; set; }
    }

    public class GoalResult : IGoalResult
    {
        public IGoal Goal { get; set; }
        public IConnectable[] Plan { get; set; }
        public IGoapAction Action { get; set; }
    }
}
