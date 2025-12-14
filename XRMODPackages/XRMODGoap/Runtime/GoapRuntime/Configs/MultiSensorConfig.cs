using System;
using Goap.Core;

namespace Goap.Runtime
{
    public class MultiSensorConfig : IMultiSensorConfig, IClassCallbackConfig
    {
        public string Name { get; set; }
        public string ClassType { get; set; }
        public Action<object> Callback { get; set; }
    }
}