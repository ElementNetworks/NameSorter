using NameSorter.Entity.Person.Interface;
using NameSorter.Entity.Person.Validator;
using NameSorter.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person
{ 
    /// <summary>
    /// This class handle parsing of person data and assigning it to person object
    /// </summary>
    public class PersonFileParser : IPersonParser
    {
        public IEnumerable<string> ParserMessage { get; set; }

        /// <summary>
        /// Parse data seperated by newline and assign to person object
        /// </summary>
        /// <param name="fileData">Data separated by newline</param>
        /// <returns>List of persons</returns>
        public IList<PersonDTO> Parse(string fileData)
        {
            IList<PersonDTO> persons = new List<PersonDTO>();
            string[] lines = fileData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                var givenName = "";
                var lastName = "";
                
                if (line.IndexOf(" ") > 0)
                {
                    givenName = line.Substring(0, line.LastIndexOf(" "));
                    lastName = line.Substring(line.LastIndexOf(" ") + 1);
                }  
                else
                {
                    givenName = line;
                }
                var p = new PersonDTO(givenName, lastName);
                persons.Add(p); 
            }

            return persons;
        } 
    }
}
