using NameSorter.Entity.Person.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person
{ 
    /// <summary>
    /// This class handle action of creating output text file format
    /// </summary>
    public class PersonFileWriter : IPersonWriter
    {
        private readonly string _filename;

        public PersonFileWriter(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// Write output string as text format to a specified file path
        /// </summary>
        /// <param name="persons">List of persons</param>
        public void Write(IList<PersonDTO> persons)
        { 
            using (StreamWriter sw = new StreamWriter(_filename))
            {
                foreach (var person in persons)
                {
                    sw.WriteLine(person.ToString());
                }
            }
        }
    }
}
