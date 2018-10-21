using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter.Entity.Person
{
    /// <summary>
    /// Compare a person object first by last name, then by any given names the person may have
    /// </summary>
    public class PersonNameComparer : IComparer<PersonDTO>
    {
        public int Compare(PersonDTO first, PersonDTO second)
        {
            var lastName = first.LastName.CompareTo(second.LastName);
            if (lastName == 0)
                return first.GivenName.CompareTo(second.GivenName);
            return lastName;
        }
    }
}
