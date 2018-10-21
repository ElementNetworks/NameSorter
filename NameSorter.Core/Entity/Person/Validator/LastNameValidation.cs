using NameSorter.Core.Entity;
using NameSorter.Core.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Entity.Person.Validator
{
    public class LastNameValidation : ValidationBase<PersonDTO>
    { 
        public LastNameValidation(PersonDTO context)
            : base(context)
        {
        }

        public override bool IsValid
        {
            get { return !string.IsNullOrEmpty(Context.LastName); }
        }

        public override string Message
        {
            get
            {
                return "LastName is required.";
            }
        }
    }
}
