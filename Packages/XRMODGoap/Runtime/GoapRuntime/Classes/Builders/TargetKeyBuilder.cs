using Goap.Agent.Runtime;
using Goap.Core;

namespace Goap.Runtime
{
    public class TargetKeyBuilder : KeyBuilderBase<ITargetKey>
    {
        protected override void InjectData(ITargetKey key)
        {
            if (key is TargetKeyBase targetKey)
                targetKey.Name = TypeReSolveHelper.ResolveType(key).GetGenericTypeName();
        }
    }
}