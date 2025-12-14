using Goap.Core;

namespace Goap.Goap.Resolver
{
    public interface IExecutableBuilder
    {
        IExecutableBuilder SetExecutable(IConnectable action, bool executable);
        void Clear();
        bool[] Build();
    }
}