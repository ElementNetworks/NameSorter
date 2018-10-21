using NameSorter.Entity.Person.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person
{
    public class PersonProcessor
    {
        public IEnumerable<string> Messages { get; set; }

        /// <summary>
        /// Start processing person object from reading, parsing, validating, sorting, and writing to output file 
        /// </summary>
        /// <param name="reader">person data provider</param>
        /// <param name="parser">person data parser</param>
        /// <param name="writer">person data writer</param>
        /// <param name="validator">person data validator</param>
        /// <param name="sorter">person data sorter</param>
        /// <returns>List of persons</returns>
        public IList<PersonDTO> Process(IPersonReader reader, IPersonParser parser, IPersonWriter writer, IPersonValidator validator, IPersonSorter sorter)
        {
            Messages = new List<String>();

            var providedData = reader.Read();

            var parsedData = parser.Parse(providedData); 

            var validatedData = validator.Validate(parsedData); 

            var sortedData = sorter.Sort(validatedData);

            writer.Write(sortedData); 

            Messages = Messages.Concat(validator.Messages);

            return sortedData;
        }
    }
}
