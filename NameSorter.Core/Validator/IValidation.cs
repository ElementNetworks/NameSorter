using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Validator
{
    public interface IValidation
    {
        bool IsValid { get; } // True when valid
        void Validate(); // Start validation
        string Message { get; } // The message when object is not valid
    }
}
