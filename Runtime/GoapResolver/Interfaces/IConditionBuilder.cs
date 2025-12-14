using Goap.Core;

namespace Goap.Goap.Resolver
{
    public interface IConditionBuilder
    {
        IConditionBuilder SetConditionMet(ICondition condition, bool met);
        bool[] Build();
        void Clear();
    }
}