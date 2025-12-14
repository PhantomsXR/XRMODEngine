using System;

namespace Goap.Runtime
{
    [Serializable]
    public class CapabilityMultiSensor : CapabilitySensor
    {
        public override string ToString() => this.sensor.Name;
    }
}