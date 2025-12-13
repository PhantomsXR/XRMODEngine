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
using System.Collections.Generic;
using Goap.Agent.Core;
using Goap.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime
{
    public class PearSensor : MultiSensorBase
    {
        private PearBehaviour[] pears = Array.Empty<PearBehaviour>();

        public PearSensor()
        {
            this.AddLocalWorldSensor<PearCount>((agent, references) =>
            {
                // Get a cached reference to the DataBehaviour on the agent
                var data = references.GetCachedComponent<DataBehaviour>();
                return data.pearCount;
            });

            this.AddLocalWorldSensor<Hunger>((agent, references) =>
            {
                // Get a cached reference to the DataBehaviour on the agent
                var data = references.GetCachedComponent<DataBehaviour>();
                // We need to cast the float to an int, because the hunger is an int
                // We will lose the decimal values, but we don't need them for this example
                return (int) data.hunger;
            });

            this.AddLocalTargetSensor(typeof(ClosestPear), Sense);
        }

        private ITarget Sense(IActionReceiver agent, IComponentReference _arg2, ITarget target)
        {
            // Use the cashed pears list to find the closest pear
            try
            {
                PearBehaviour closestPear = this.Closest(this.pears, agent.Transform.position);

                if (closestPear == null)
                    return null;

                // If the target is a transform target, set the target to the closest pear
                if (target is TransformTarget transformTarget)
                    return transformTarget.SetTransform(closestPear.transform);

                return new TransformTarget(closestPear.transform); 
            }
            catch (Exception tmp_Exception)
            {
                Debug.Log(tmp_Exception);
                throw;
            }
        }

        // Returns the closest item in a list
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

        public override void Created()
        {
        }

        public override void Update()
        {
            pears = Object.FindObjectsByType<PearBehaviour>(FindObjectsSortMode.None);
        }
    }
}