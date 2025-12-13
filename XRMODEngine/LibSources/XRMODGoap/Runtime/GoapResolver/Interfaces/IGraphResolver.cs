using Goap.Core;

namespace Goap.Goap.Resolver
{
    public interface IGraphResolver
    {
        IResolveHandle StartResolve(RunData runData);
        IEnabledBuilder GetEnabledBuilder();
        IExecutableBuilder GetExecutableBuilder();
        IPositionBuilder GetPositionBuilder();
        ICostBuilder GetCostBuilder();
        IGraph GetGraph();
        int GetIndex(IConnectable action);
        IGoapAction GetAction(int index);
        void Dispose();
        IConditionBuilder GetConditionBuilder();
    }
}