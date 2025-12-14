using Goap.Agent.Core;

namespace Goap.Agent.Runtime
{
    public class ActionContext : IActionContext
    {
        public float DeltaTime { get; set; }
        public bool IsInRange { get; set; }
    }
}