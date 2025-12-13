using Goap.Core;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace Goap.Runtime
{
    public abstract class AgentTypeFactoryBase : XRMODBehaviour
    {
        public abstract IAgentTypeConfig Create();
    }
}