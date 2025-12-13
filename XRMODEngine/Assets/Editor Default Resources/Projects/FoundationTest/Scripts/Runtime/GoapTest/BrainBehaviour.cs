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
using Goap.Agent.Runtime;
using Goap.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime
{
    public class BrainBehaviour : XRMODBehaviour
    {
        [SerializeField] private AgentBehaviour agent;
        [SerializeField] private GoapActionProvider provider;
        [SerializeField] private GoapBehaviour goap;
        private DataBehaviour data;

        private void Awake()
        {
            if (!enabled) return;
            this.goap = FindFirstObjectByType<GoapBehaviour>();
            this.agent = this.GetComponent<AgentBehaviour>();
            this.provider = this.GetComponent<GoapActionProvider>();
            this.data = this.GetComponent<DataBehaviour>();

            // This only applies sto the code demo
            if (this.provider.AgentTypeBehaviour == null)
                this.provider.AgentType = this.goap.GetAgentType("ScriptDemoAgent");
        }

        private void Start()
        {
            // this.provider.RequestGoal<IdleGoal>();
            // this.provider.RequestGoal<PickupPearGoal>();
            this.provider.RequestGoal<IdleGoal, PickupPearGoal>();


            agent.Events.OnActionComplete += OnActionEnd;
            agent.Events.OnActionStart += OnActionEnd;
            agent.Events.OnActionStop += OnActionEnd;
            agent.Events.OnMove += _target => { };
            agent.Events.OnTargetChanged += (_target, _range) => { };
            agent.Events.OnTargetLost += () => { };
            agent.Events.OnTargetInRange += _target => { };
            agent.Events.OnTargetNotInRange += _target => { };
        }

        private void OnEnable()
        {
            agent.Events.OnActionEnd += OnActionEnd;
        }

        private void OnDisable()
        {
            agent.Events.OnActionEnd -= OnActionEnd;
        }

        private void OnActionEnd(IAction _action)
        {
            if (data.hunger > 50)
            {
                provider.RequestGoal<EatGoal>();
                return;
            }

            this.provider.RequestGoal<IdleGoal, PickupPearGoal>();
        }
    }
}