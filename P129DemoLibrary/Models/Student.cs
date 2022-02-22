using System;
using System.Collections.Generic;
using System.Text;

namespace P129DemoLibrary.Models
{
    public class Student
    {
        public string Name { get; set; }
        internal string Surname { get; set; }
        protected internal int Age { get; set; }
        private protected int Grade { get; set; }
    }
}
