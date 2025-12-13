using System;
using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    [Obsolete("Use CapabilityConfigs instead!")]
    public class TargetKeyScriptable : ScriptableObject, ITargetKey
    {
        public string Name => this.name;
    }
}