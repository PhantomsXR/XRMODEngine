namespace Goap.Agent.Core
{
    public interface IActionContext
    {
        float DeltaTime { get; set; }
        public bool IsInRange { get; set; }
    }
}