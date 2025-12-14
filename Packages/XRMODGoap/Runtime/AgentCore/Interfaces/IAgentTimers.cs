namespace Goap.Agent.Core
{
    public interface IAgentTimers
    {
        ITimer Action { get; }
        ITimer Goal { get; }
        ITimer Resolve { get; }
    }
}