using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person.Interface
{
    public interface IPersonValidator
    {
        IList<PersonDTO> Validate(IList<PersonDTO> persons);
        IEnumerable<string> Messages { get; set; }
        bool IsValid { get; }
    }
}
