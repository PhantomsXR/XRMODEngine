using System.Collections.Generic;
using System.Linq;
using Goap.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Goap.Runtime
{
    [CreateAssetMenu(menuName = "XR-MOD/Tools/Goap/AgentTypeConfig")]
    public class AgentTypeScriptable : ScriptableObject
    {
        [FormerlySerializedAs("capabilityFactories")]
        public List<ScriptableCapabilityFactoryBase> capabilities = new();

        public string Name => this.name;

        public IAgentTypeConfig Create()
        {
            var configs = this.capabilities
                .Select(behaviour => behaviour.Create())
                .ToList();

            return new AgentTypeConfig(this.name)
            {
                Goals = configs.SelectMany(x => x.Goals).ToList(),
                Actions = configs.SelectMany(x => x.Actions).ToList(),
                WorldSensors = configs.SelectMany(x => x.WorldSensors).ToList(),
                TargetSensors = configs.SelectMany(x => x.TargetSensors).ToList(),
                MultiSensors = configs.SelectMany(x => x.MultiSensors).ToList(),
            };
        }
    }
}
