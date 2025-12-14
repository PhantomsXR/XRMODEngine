using UnityEngine;

namespace Goap.Agent.Core
{
    public interface ITarget
    {
        public Vector3 Position { get; }
        public bool IsValid();
    }
}