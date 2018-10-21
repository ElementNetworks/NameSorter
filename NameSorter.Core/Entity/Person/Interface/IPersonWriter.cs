using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person.Interface
{
    public interface IPersonWriter
    {
        void Write(IList<PersonDTO> PersonData);
    }
}
