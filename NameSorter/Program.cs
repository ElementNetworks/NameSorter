using NameSorter.Entity;
using NameSorter.Entity.Person; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NameSorter
{
    /// <summary>
    /// Build a name sorter. 
    /// Given a set of names, order that set first by last name, then by any given names the person may have. 
    /// A name must have at least 1 given name and may have up to 3 given names.
    /// </summary>
    class Program
    { 
        static void Main(string[] args)
        { 
            try
            {
                
                string outputFilename = "sorted-names-list.txt"; 
#if DEBUG
                string inputFilename = "./unsorted-names-list.txt";
#else
                string inputFilename = args[0];
#endif

                var reader = new PersonFileReader(inputFilename);
                var parser = new PersonFileParser();
                var writer = new PersonFileWriter(outputFilename);
                var sorter = new PersonSorter(new PersonNameComparer());
                var validator = new PersonValidator();
                var processor = new PersonProcessor(); 
                var sortedList = processor.Process(reader, parser, writer, validator, sorter);

                foreach (var person in sortedList)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

            Console.Read();
        }
         
    }
}
