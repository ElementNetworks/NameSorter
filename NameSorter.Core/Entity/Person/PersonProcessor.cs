using NameSorter.Core.Entity.Person.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person
{
    /// <summary>
    /// Main class to process person data
    /// </summary>
    public class PersonProcessor
    {
        public IEnumerable<string> Messages { get; set; }
        private IPersonReader _reader;
        private IPersonParser _parser;
        private IPersonWriter _writer;
        private IPersonValidator _validator;
        private IPersonSorter _sorter;

        public PersonProcessor(IPersonReader reader, IPersonParser parser, IPersonWriter writer, IPersonValidator validator, IPersonSorter sorter)
        {
            _reader = reader;
            _parser = parser;
            _writer = writer;
            _validator = validator;
            _sorter = sorter;
        }

        /// <summary>
        /// Start processing person object from reading, parsing, validating, sorting, and writing to output file 
        /// </summary>
        /// <param name="reader">person data provider</param>
        /// <param name="parser">person data parser</param>
        /// <param name="writer">person data writer</param>
        /// <param name="validator">person data validator</param>
        /// <param name="sorter">person data sorter</param>
        /// <returns>List of persons</returns>
        public IList<PersonDTO> Process()
        {
            Messages = new List<String>();

            var providedData = _reader.Read();

            var parsedData = _parser.Parse(providedData); 

            var validatedData = _validator.Validate(parsedData); 

            var sortedData = _sorter.Sort(validatedData);

            _writer.Write(sortedData); 

            Messages = Messages.Concat(_validator.Messages);

            return sortedData;
        }
    }
}
