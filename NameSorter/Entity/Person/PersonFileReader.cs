﻿using NameSorter.Entity.Person.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Entity.Person
{ 
    /// <summary>
    /// This class handle action of reading text file and return its content
    /// </summary>
    public class PersonFileReader : IPersonReader
    {
        private readonly string _filename;

        public PersonFileReader(string filename)
        {
            _filename = filename;
        }

        /// <summary>
        /// Read text file format from specified file path
        /// </summary>
        /// <returns>Content of file</returns>
        public string Read()
        {
            var result = "";
            using (StreamReader sr = new StreamReader(_filename, Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
