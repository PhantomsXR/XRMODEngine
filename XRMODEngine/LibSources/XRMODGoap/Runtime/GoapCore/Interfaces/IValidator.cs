namespace Goap.Core
{
    public interface IValidator<T>
    {
        void Validate(T config, IValidationResults results);
    }
}