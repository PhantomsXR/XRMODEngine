using Goap.Core;
using Goap.Runtime;
using UnityEditor;

namespace Goap.Goap.Editor
{
    [CustomPropertyDrawer(typeof(GoalClassAttribute))]
    public class GoalClassDrawer : ClassDrawerBase<IGoal>
    {
    }
}