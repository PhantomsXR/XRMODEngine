using Goap.Core;

namespace Goap.Goap.Resolver
{
    public interface IEnabledBuilder
    {
        IEnabledBuilder SetEnabled(IConnectable action, bool executable);
        void Clear();
        bool[] Build();
    }
}