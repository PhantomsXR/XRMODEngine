namespace Goap.Agent.Core
{
    public interface IDataReferenceInjector : IComponentReference
    {
        void Inject(IActionData data);
    }
}