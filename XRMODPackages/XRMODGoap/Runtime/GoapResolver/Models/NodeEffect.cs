using System;
using Goap.Core;

namespace Goap.Goap.Resolver
{
    public class NodeEffect : INodeEffect
    {
        public IEffect Effect { get; set; }
        public INode[] Connections { get; set; } = Array.Empty<INode>();
    }
}