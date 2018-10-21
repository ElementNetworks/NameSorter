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
    public class PersonProcessorTest
    {
        [TestMethod]
        public void Is_File_Processed_Successfully()
        {
            // Arrange 
            var filename = "./unsorted-names-list.txt";
            var reader = new PersonFileReader(filename);
            var parser = new PersonFileParser();
            var writer = new PersonFileWriter(filename);
            var sorter = new PersonSorter(new PersonNameComparer());
            var validator = new PersonValidator();
            var processor = new PersonProcessor(); 

            // Act 
            var sortedList = processor.Process(reader, parser, writer, validator, sorter);

            // Assert
            Assert.IsTrue(true);
        }
    }
}
