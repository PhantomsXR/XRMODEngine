using System.Collections.Generic;

namespace Goap.Core
{
    public interface IValidationResults
    {
        void AddError(string error);
        void AddWarning(string warning);
        List<string> GetErrors();
        List<string> GetWarnings();
        bool HasErrors();
        bool HasWarnings();
    }
}