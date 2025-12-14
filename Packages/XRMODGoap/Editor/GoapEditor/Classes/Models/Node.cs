using System;
using Goap.Core;

namespace Goap.Goap.Editor
{
    public class Node
    {
        public Guid Guid => this.Action.Guid;
        
        public IConnectable Action { get; set; }

        public NodeEffect[] Effects { get; set; } = {};
        public NodeCondition[] Conditions { get; set; } = {};
    }
}