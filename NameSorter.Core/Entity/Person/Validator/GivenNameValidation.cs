using NameSorter.Core.Entity;
using NameSorter.Core.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person.Validator
{
    /// <summary>
    /// Validate a person given name: A name must have at least 1 given name and may have up to 3 given names
    /// </summary>
    public class GivenNameValidation : ValidationBase<PersonDTO>
    { 
        public GivenNameValidation(PersonDTO context)
            : base(context)
        {
        }

        public override bool IsValid
        {
            get
            {
                string[] names = Context.GivenName.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                return !string.IsNullOrEmpty(Context.GivenName) && names.Length <= 3;
            }
        }

        public override string Message
        {
            get
            {
                return "GivenName is required or it cannot exceed 3 names.";
            }
        }
    }
}
