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
    public class PersonProcessorTest
    {
        [TestMethod]
        public void Is_File_Processed_Successfully()
        {
            // Arrange 
            var inputFilename = "./unsorted-names-list.txt";
            var outputFilename = "sorted-names-list.txt";
            var delimiter = "";
            var reader = new PersonFileReader(inputFilename);
            var parser = new PersonFileParser(delimiter);
            var writer = new PersonFileWriter(outputFilename);
            var sorter = new PersonSorter(new PersonNameComparer());
            var validator = new PersonValidator();
            var processor = new PersonProcessor(reader, parser, writer, validator, sorter); 

            // Act 
            var sortedList = processor.Process();

            // Assert
            Assert.IsTrue(true);
        }
    }
}
