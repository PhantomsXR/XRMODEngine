using Goap.Core;

namespace Goap.Runtime
{
    public class TargetKey : ITargetKey
    {
        public TargetKey(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
