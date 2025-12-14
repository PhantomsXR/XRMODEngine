using System.Collections.Generic;

namespace Goap.Core
{
    public interface IGraph
    {
        List<INode> RootNodes { get; set; }
        List<INode> ChildNodes { get; set; }
        INode[] AllNodes { get; }
        INode[] UnconnectedNodes { get; }
    }
}