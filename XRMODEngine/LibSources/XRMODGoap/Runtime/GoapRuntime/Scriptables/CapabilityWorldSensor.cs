using System;

namespace Goap.Runtime
{
    [Serializable]
    public class CapabilityWorldSensor : CapabilitySensor
    {
        public ClassRef worldKey = new();

        public override string ToString() => $"{this.sensor.Name} ({this.worldKey.Name})";
    }
}