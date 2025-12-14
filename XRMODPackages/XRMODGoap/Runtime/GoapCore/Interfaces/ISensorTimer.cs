using Goap.Agent.Core;

namespace Goap.Core
{
    public interface ISensorTimer
    {
        bool ShouldSense(ITimer timer);
    }
}