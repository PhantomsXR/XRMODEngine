using System;
using Goap.Core;

namespace Goap.Goap.Resolver
{
    public class NodeCondition : INodeCondition
    {
        public ICondition Condition { get; set; }
        public INode[] Connections { get; set; } = Array.Empty<INode>();
    }
}