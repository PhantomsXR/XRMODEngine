using Goap.Agent.Core;

namespace Goap.Agent.Runtime
{
    // Backwards compatibility for old actions
    public abstract class AgentActionBase<TActionData> : AgentActionBase<TActionData, EmptyActionProperties>
        where TActionData : IActionData, new()
    {
    }
}