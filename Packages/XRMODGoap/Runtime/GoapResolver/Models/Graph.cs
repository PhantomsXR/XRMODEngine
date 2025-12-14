using System.Collections.Generic;
using System.Linq;
using Goap.Core;

namespace Goap.Goap.Resolver
{
    public class Graph : IGraph
    {
        public List<INode> RootNodes { get; set; } = new();
        public List<INode> ChildNodes { get; set; } = new();
        public INode[] AllNodes => this.RootNodes.Union(this.ChildNodes).ToArray();
        public INode[] UnconnectedNodes { get; set; }
    }
}