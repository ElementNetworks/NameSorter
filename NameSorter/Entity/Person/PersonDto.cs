using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person
{ 
    /// <summary>
    /// This class holds attributes belonging to a person such as name, age, etc
    /// </summary>
    public class PersonDTO
    { 
        public string GivenName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", GivenName, LastName);
            }
        }
         
        public PersonDTO(string givenName, string lastName)
        {
            GivenName = givenName;
            LastName = lastName; 
        }

        /// <summary>
        /// Output a person fullname
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName;
        }
    } 
}
