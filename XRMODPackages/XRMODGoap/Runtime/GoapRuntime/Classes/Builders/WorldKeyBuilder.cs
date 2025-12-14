using Goap.Agent.Runtime;
using Goap.Core;

namespace Goap.Runtime
{
    public class WorldKeyBuilder : KeyBuilderBase<IWorldKey>
    {
        protected override void InjectData(IWorldKey key)
        {
            if (key is WorldKeyBase worldKey)
                worldKey.Name = TypeReSolveHelper.ResolveType(key).GetGenericTypeName();
        }
    }
}