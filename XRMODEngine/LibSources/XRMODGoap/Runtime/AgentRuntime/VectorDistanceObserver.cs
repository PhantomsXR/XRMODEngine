using Goap.Agent.Core;
using UnityEngine;

namespace Goap.Agent.Runtime
{
    public class VectorDistanceObserver : IAgentDistanceObserver
    {
        public float GetDistance(IMonoAgent agent, ITarget target, IComponentReference reference)
        {
            if (agent.transform == null)
                return 0f;

            if (target == null)
                return 0f;

            return !target.IsValid() ? 0f : Vector3.Distance(agent.transform.position, target.Position);
        }
    }
}