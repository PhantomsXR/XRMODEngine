using System;

namespace Goap.Runtime
{
    [Serializable]
    public abstract class CapabilitySensor
    {
        public ClassRef sensor = new();
    }
}