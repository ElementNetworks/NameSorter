using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Entity.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests.Entity.Person
{
    [TestClass]
    public class PersonValidatorTest
    {
        [TestMethod]
        public void Is_Valid_GivenName_And_LastName()
        {
            // Arrange 
            var validator = new PersonValidator();
            var list = new List<PersonDTO>();
            list.Add(new PersonDTO("one two three", "B"));
            list.Add(new PersonDTO("one", "A"));

            // Act 
            var validatedList = validator.Validate(list);

            // Assert
            Assert.IsTrue(validator.IsValid);
        }

        
    }
}
