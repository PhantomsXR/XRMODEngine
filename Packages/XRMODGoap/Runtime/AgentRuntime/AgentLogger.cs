using Goap.Agent.Core;
using Goap.Core;

namespace Goap.Agent.Runtime
{
    public class AgentLogger : LoggerBase<IMonoAgent>
    {
        protected override string Name => this.source.name;

        protected override void RegisterEvents()
        {
            if (this.source == null)
                return;

            this.source.Events.OnActionStart += this.ActionStart;
            this.source.Events.OnActionStop += this.ActionStop;
            this.source.Events.OnActionComplete += this.ActionComplete;
        }

        protected override void UnregisterEvents()
        {
            if (this.source == null)
                return;

            this.source.Events.OnActionStart -= this.ActionStart;
            this.source.Events.OnActionStop -= this.ActionStop;
            this.source.Events.OnActionComplete -= this.ActionComplete;
        }

        private void ActionStart(IAction action)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Log($"Action {TypeReSolveHelper.ResolveType(action)?.GetGenericTypeName()} started");
        }

        private void ActionStop(IAction action)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Log($"Action {TypeReSolveHelper.ResolveType(action)?.GetGenericTypeName()} stopped");
        }

        private void ActionComplete(IAction action)
        {
            if (this.config.DebugMode == DebugMode.None)
                return;

            this.Log($"Action {TypeReSolveHelper.ResolveType(action)?.GetGenericTypeName()} completed");
        }
    }
}
