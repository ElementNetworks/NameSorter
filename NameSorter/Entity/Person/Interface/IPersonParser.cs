using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person.Interface
{
    public interface IPersonParser
    {
        IList<PersonDTO> Parse(string personList);
    }
}
