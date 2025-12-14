using System.Linq;
using Goap.Agent.Core;
using Goap.Agent.Runtime;
using Goap.Core;

namespace Goap.Runtime
{
    public class GoapAgentLogger : LoggerBase<IMonoGoapActionProvider>
    {
        protected override string Name => this.source.name;

        protected override void RegisterEvents()
        {
            if (this.source == null)
                return;

            // Todo
            this.source.Events.OnNoActionFound += this.NoActionFound;
            this.source.Events.OnGoalStart += this.GoalStart;
            this.source.Events.OnGoalCompleted += this.GoalCompleted;
        }

        protected override void UnregisterEvents()
        {
            if (this.source == null)
                return;

            // Todo
            this.source.Events.OnNoActionFound -= this.NoActionFound;
            this.source.Events.OnGoalStart -= this.GoalStart;
            this.source.Events.OnGoalCompleted -= this.GoalCompleted;
        }

        private void NoActionFound(IGoalRequest request)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Handle(
                $"No action found for goals {string.Join(", ", request.Goals.Select(x => TypeReSolveHelper.ResolveType(x).GetGenericTypeName()))}",
                DebugSeverity.Warning);
        }

        private void GoalStart(IGoal goal)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Handle($"Goal {TypeReSolveHelper.ResolveType(goal)?.GetGenericTypeName()} started", DebugSeverity.Log);
        }

        private void GoalCompleted(IGoal goal)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Handle($"Goal {TypeReSolveHelper.ResolveType(goal)?.GetGenericTypeName()} completed", DebugSeverity.Log);
        }
    }
}