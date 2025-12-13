using System;
using Goap.Core;
using Goap.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime
{
    public class DemoAgentTypeFactory : AgentTypeFactoryBase
    {
        private void Awake()
        {
            if (!enabled) return;
            var tmp_GoapBehaviour = FindFirstObjectByType<GoapBehaviour>(FindObjectsInactive.Include);
            tmp_GoapBehaviour.agentTypeConfigFactories.Add(this);
            tmp_GoapBehaviour.Initialize();
        }

        public override IAgentTypeConfig Create()
        {
            var tmp_Factory = new AgentTypeBuilder("ScriptDemoAgent");
            tmp_Factory.AddCapability<IdleCapabilityFactory>();
            tmp_Factory.AddCapability<PearCapability>();
            tmp_Factory.AddCapability<EatCapability>();
            return tmp_Factory.Build();
        }
    }
}