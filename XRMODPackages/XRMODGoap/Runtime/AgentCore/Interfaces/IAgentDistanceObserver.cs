namespace Goap.Agent.Core
{
    public interface IAgentDistanceObserver
    {
        float GetDistance(IMonoAgent agent, ITarget target, IComponentReference reference);
    }
}