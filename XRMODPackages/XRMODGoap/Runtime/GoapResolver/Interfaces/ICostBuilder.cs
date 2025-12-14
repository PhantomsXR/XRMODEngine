using Goap.Core;

namespace Goap.Goap.Resolver
{
    public interface ICostBuilder
    {
        ICostBuilder SetCost(IConnectable action, float cost);
        float[] Build();
        void Clear();
    }
}