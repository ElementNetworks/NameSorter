using NameSorter.Core.Entity.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Console
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
#if RELEASE
            if (args.Length < 1)
            {
                System.Console.WriteLine("Usage: name-sorter filename");
            } 
            string inputFilename = args[0];
#else 
            string inputFilename = "./unsorted-names-list.txt"; 
#endif

            SortNames(inputFilename);
            System.Console.Read();
        }

        /// <summary>
        /// Sorts the names in the given file
        /// outputs sorted names into a file named "sorted-names-list.txt".
        /// </summary>
        /// <param name="inputFilename">The file to sort.</param>
        private static void SortNames(string inputFilename)
        {
            try
            {
                var delimiter = " ";
                var outputFilename = "sorted-names-list.txt"; 

                var reader = new PersonFileReader(inputFilename);
                var parser = new PersonFileParser(delimiter);
                var writer = new PersonFileWriter(outputFilename);
                var sorter = new PersonSorter(new PersonNameComparer());
                var validator = new PersonValidator();
                var processor = new PersonProcessor(reader, parser, writer, validator, sorter);
                var sortedList = processor.Process();

                foreach (var person in sortedList)
                {
                    System.Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }  
        }
    }
}
