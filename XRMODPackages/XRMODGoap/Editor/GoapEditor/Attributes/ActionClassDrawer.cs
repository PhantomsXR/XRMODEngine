using Goap.Agent.Core;
using Goap.Runtime;
using UnityEditor;

namespace Goap.Goap.Editor
{
    [CustomPropertyDrawer(typeof(ActionClassAttribute))]
    public class ActionClassDrawer : ClassDrawerBase<IAction>
    {
    }
}