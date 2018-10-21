using NameSorter.Core.Entity.Person.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person
{ 
    /// <summary>
    /// This class uses comparer function to sort the list of person
    /// </summary>
    public class PersonSorter : IPersonSorter
    {
        private readonly IComparer<PersonDTO> _comparer;
        public PersonSorter(IComparer<PersonDTO> comparer)
        {
            _comparer = comparer;
        }

        /// <summary>
        /// starts sorting list of person
        /// </summary>
        /// <param name="persons">List of persons</param>
        /// <returns>sorted list of persons</returns>
        public IList<PersonDTO> Sort(IList<PersonDTO> persons)
        {
            var list = persons.ToList();
            list.Sort(_comparer);
            return list;
        }
    }
}
