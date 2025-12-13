using Goap.Agent.Core;

namespace Goap.Agent.Runtime
{
    public static class ActionDisabler
    {
        public static IActionDisabler Forever => new ForeverActionDisabler();
        public static IActionDisabler ForTime(float time) => new ForTimeActionDisabler(time);
    }
}
