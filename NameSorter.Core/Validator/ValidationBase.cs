using NameSorter.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Core.Validator
{
    public abstract class ValidationBase<T> : IValidation where T : class
    {
        protected T Context { get; private set; }

        protected ValidationBase(T context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            Context = context;
        }

        public void Validate()
        {
            if (!IsValid)
            {
                //throw new ValidationException(Message);
            }
        }

        public abstract bool IsValid { get; }
        public abstract string Message { get; }
    }
}
