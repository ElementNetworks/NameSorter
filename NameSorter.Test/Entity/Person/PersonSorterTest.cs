using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Core.Entity.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests.Entity.Person
{
    [TestClass]
    public class PersonSorterTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void Is_List_Sorted_By_LastName()
        {
            var sorter = new PersonSorter(new PersonNameComparer());
            var list = new List<PersonDTO>(); 
            list.Add(new PersonDTO("two", "B"));
            list.Add(new PersonDTO("one", "A"));
            list.Add(new PersonDTO("four", "D"));
            list.Add(new PersonDTO("three", "C"));

            var sortedList = sorter.Sort(list);

            Assert.AreEqual("A", sortedList.First().LastName);
        }

        [TestMethod]
        public void Given_List_With_OneName_Return_OneName()
        {
            var sorter = new PersonSorter(new PersonNameComparer());
            var list = new List<PersonDTO>();
            list.Add(new PersonDTO("one", "A"));

            var sortedList = sorter.Sort(list);

            Assert.AreEqual("A", sortedList.First().LastName);
        }
    }
}
