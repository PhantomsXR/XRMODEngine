namespace Goap.Core
{
    public interface IGoapController
    {
        void Initialize(IGoap goap);
        void OnUpdate();
        void OnLateUpdate();
    }
}