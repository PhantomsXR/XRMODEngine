using System;
using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    [Obsolete("Use CapabilityConfigs instead!")]
    public class WorldKeyScriptable : ScriptableObject, IWorldKey
    {
        public string Name => this.name;
    }
}