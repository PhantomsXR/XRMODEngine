using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    public abstract class CapabilityFactoryBase
    {
        public abstract ICapabilityConfig Create();
    }

    public abstract class MonoCapabilityFactoryBase : Phantom.XRMOD.Core.Runtime.XRMODBehaviour
    {
        public abstract ICapabilityConfig Create();
    }

    public abstract class ScriptableCapabilityFactoryBase : ScriptableObject
    {
        public abstract ICapabilityConfig Create();
    }
}