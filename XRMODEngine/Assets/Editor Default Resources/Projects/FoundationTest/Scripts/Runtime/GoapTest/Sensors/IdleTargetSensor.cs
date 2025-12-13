using Goap.Agent.Core;
using Goap.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime
{
    public class IdleTargetSensor : LocalTargetSensorBase
    {
        private static readonly Vector2 Bounds = new Vector2(15, 8);

        public override void Created()
        {
        }

        public override void Update()
        {
        }

        public override ITarget Sense(IActionReceiver agent, IComponentReference references, ITarget existingTarget)
        {
            var tmp_Random = GetRandomPosition(agent);
            if (existingTarget is PositionTarget tmp_ExistingTarget)
            {
                return tmp_ExistingTarget.SetPosition(tmp_Random);
            }

            return new PositionTarget(tmp_Random);
        }

        private Vector3 GetRandomPosition(IActionReceiver _agent)
        {
            while (true)
            {
                var tmp_Random = Random.insideUnitCircle * 3f;
                var tmp_Position = _agent.Transform.position + new Vector3(tmp_Random.x, 0, tmp_Random.y);
                if (tmp_Position.x > -Bounds.x && tmp_Position.x < Bounds.x && tmp_Position.z > -Bounds.y &&
                    tmp_Position.z < Bounds.y)
                    return tmp_Position;
            }
        }
    }
}