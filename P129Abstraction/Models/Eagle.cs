using System;
using System.Collections.Generic;
using System.Text;

namespace P129Abstraction.Models
{
    class Eagle : Birds
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }
    }
}
