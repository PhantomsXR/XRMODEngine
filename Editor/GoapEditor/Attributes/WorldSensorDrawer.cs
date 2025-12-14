using Goap.Core;
using Goap.Runtime;
using UnityEditor;

namespace Goap.Goap.Editor
{
    [CustomPropertyDrawer(typeof(WorldSensorAttribute))]
    public class WorldSensorDrawer : ClassDrawerBase<IWorldSensor>
    {
    }
}