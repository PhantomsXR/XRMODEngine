using Goap.Core;
using Goap.Runtime;
using UnityEditor;

namespace Goap.Goap.Editor
{
    [CustomPropertyDrawer(typeof(TargetSensorAttribute))]
    public class TargetSensorDrawer : ClassDrawerBase<ITargetSensor>
    {
    }
}