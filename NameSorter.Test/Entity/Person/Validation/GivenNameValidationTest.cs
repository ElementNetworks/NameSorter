using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Entity.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests.Entity.Person.Validation
{
    [TestClass]
    public class GivenNameValidationTest
    {
        [TestMethod]
        public void Is_Valid_GivenName()
        {
            // Arrange 
            var validator = new PersonValidator();
            var list = new List<PersonDTO>();
            list.Add(new PersonDTO("one", "A"));
            list.Add(new PersonDTO("one two", "A"));
            list.Add(new PersonDTO("one two three", "B"));

            // Act 
            var validatedList = validator.Validate(list);

            // Assert
            Assert.IsTrue(validator.IsValid);

        }
        [TestMethod]
        public void Is_Invalid_GivenName_EmptyName()
        {
            // Arrange 
            var validator = new PersonValidator();
            var list = new List<PersonDTO>();
            list.Add(new PersonDTO("", "B"));
            list.Add(new PersonDTO("one", "A"));

            // Act 
            var validatedList = validator.Validate(list);

            // Assert
            Assert.IsTrue(!validator.IsValid);
        }

        [TestMethod]
        public void Is_Invalid_GivenName_MoreThanThreeName()
        {
            // Arrange 
            var validator = new PersonValidator();
            var list = new List<PersonDTO>();
            list.Add(new PersonDTO("one two three four", "B"));
            list.Add(new PersonDTO("one", "A"));

            // Act 
            var validatedList = validator.Validate(list);

            // Assert
            Assert.IsTrue(!validator.IsValid);
        }
    }
}
