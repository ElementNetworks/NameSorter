using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter.Entity.Person;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Tests.Entity.Person
{
    [TestClass]
    public class PersonFileWriterTest
    {
        [TestMethod]
        public void Is_File_Created()
        {
            // Arrange
            var filename = "abc.txt";
            var pr = new PersonFileWriter(filename);
            var list = new List<PersonDTO>(); 

            // Act 
            pr.Write(list); 
            var isExist = File.Exists(Directory.GetCurrentDirectory() + "\\" + filename);

            // Assert
            Assert.IsTrue(isExist); 
        }

    }
}
