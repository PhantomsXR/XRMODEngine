using System;
using Goap.Agent.Core;
using Goap.Core;

namespace Goap.Runtime
{
    public abstract class KeyResolverBase : IKeyResolver
    {
        protected IWorldData WorldData { get; private set; }

        public void SetWorldData(IWorldData globalWorldData)
        {
            this.WorldData = globalWorldData;
        }

        public abstract string GetKey(IEffect key);
        public abstract string GetKey(ICondition key);
        public abstract bool AreConflicting(IEffect effect, ICondition condition);
    }
}
