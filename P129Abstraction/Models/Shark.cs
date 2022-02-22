using System;
using System.Collections.Generic;
using System.Text;

namespace P129Abstraction.Models
{
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Sharkd");
        }
    }
}
