using System;
using Goap.Core;

namespace Goap.Goap.Editor
{
    public class NodeEffect
    {
        public IEffect Effect { get; set; }
        public Guid[] Connections { get; set; } = {};
    }
}