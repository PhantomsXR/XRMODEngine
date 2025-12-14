namespace Goap.Core
{
    public interface IAgentTypeConfigValidatorRunner
    {
        IValidationResults Validate(IAgentTypeConfig agentTypeConfig);
    }
}