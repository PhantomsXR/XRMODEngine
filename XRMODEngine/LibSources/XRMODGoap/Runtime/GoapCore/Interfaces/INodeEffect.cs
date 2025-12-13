namespace Goap.Core
{
    public interface INodeEffect
    {
        IEffect Effect { get; set; }
        INode[] Connections { get; set; }
    }
}