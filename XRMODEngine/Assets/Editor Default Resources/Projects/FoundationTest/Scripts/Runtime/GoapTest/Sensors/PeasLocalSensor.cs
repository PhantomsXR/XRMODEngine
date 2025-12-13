// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Goap.Agent.Core;
using Goap.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime
{
    public class PeasLocalSensor : LocalTargetSensorBase
    {
        private PearBehaviour[] pears = Array.Empty<PearBehaviour>();

        public override void Created()
        {
        }

        public override void Update()
        {
            pears = Object.FindObjectsByType<PearBehaviour>(FindObjectsSortMode.None);
        }

        public override ITarget Sense(IActionReceiver agent, IComponentReference references, ITarget existingTarget)
        {
            PearBehaviour closestPear = this.Closest(this.pears, agent.Transform.position);

            if (closestPear == null)
                return null;
            
            // If the target is a transform target, set the target to the closest pear
            if (existingTarget is TransformTarget transformTarget)
                return transformTarget.SetTransform(closestPear.transform);

            return new TransformTarget(closestPear.transform);
        }


        private PearBehaviour Closest(PearBehaviour[] list, Vector3 position)
        {
            PearBehaviour closest = null;
            var closestDistance = float.MaxValue; // Start with the largest possible distance

            foreach (var item in list)
            {
                var distance = Vector3.Distance(item.gameObject.transform.position, position);

                if (!(distance < closestDistance))
                    continue;

                closest = item;
                closestDistance = distance;
            }

            return closest;
        }
    }
}