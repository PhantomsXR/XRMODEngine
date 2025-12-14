using Goap.Core;

namespace Goap.Runtime
{
    public abstract class GoapConfigInitializerBase : Phantom.XRMOD.Core.Runtime.XRMODBehaviour
    {
        public abstract void InitConfig(IGoapConfig config);
    }
}