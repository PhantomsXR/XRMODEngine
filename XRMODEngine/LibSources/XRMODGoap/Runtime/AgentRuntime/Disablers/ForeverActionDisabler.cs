using Goap.Agent.Core;

namespace Goap.Agent.Runtime
{
    public class ForeverActionDisabler : IActionDisabler
    {
        public bool IsDisabled(IAgent agent) => true;
    }
}