namespace Goap.Core
{
    public interface IGoapConfig
    {
        IConditionObserver ConditionObserver { get; set; }
        IKeyResolver KeyResolver { get; set; }
        IGoapInjector GoapInjector { get; set; }
    }
}