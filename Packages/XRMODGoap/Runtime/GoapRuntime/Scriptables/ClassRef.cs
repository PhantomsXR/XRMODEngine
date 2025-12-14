using System;
using Goap.Core;
using UnityEngine;

namespace Goap.Runtime
{
    [Serializable]
    public class ClassRef : IClassRef
    {
        [field: SerializeField]
        public string Name { get; set; }

        [field: SerializeField]
        public string Id { get; set; }
    }
}
