using NameSorter.Core.Entity.Person.Interface;
using NameSorter.Core.Entity.Person.Validator;
using NameSorter.Core.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person
{ 
    /// <summary>
    /// This class handle person data validation
    /// </summary>
    public class PersonValidator : IPersonValidator
    { 
        private ValidationList _validationList; 

        public PersonValidator()
        {
        }

        /// <summary>
        /// Validate person data against a list of specified validation and it will removed invalid data from collection
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>
        public IList<PersonDTO> Validate(IList<PersonDTO> persons)
        {
            List<PersonDTO> toRemove = new List<PersonDTO>();
            Messages = new List<string>();

            foreach (var person in persons)
            {
                _validationList = new ValidationList(); 
                //_validationList.Add(new LastNameValidation(person));
                _validationList.Add(new GivenNameValidation(person));

                _validationList.Validate();

                if (!_validationList.IsValid)
                {
                    toRemove.Add(person);
                    Messages = Messages.Concat(_validationList.Messages);
                }  
            }

            foreach (var itemToBeDeleted in toRemove)
            {
                persons.Remove(itemToBeDeleted);
            }

            return persons;
        } 

        public bool IsValid
        {
            get
            {
                return Messages.Count() == 0;
            }
        }

        /// <summary>
        /// Holds the error message if not valid
        /// </summary>
        public IEnumerable<string> Messages { get; set; }
    }
}
