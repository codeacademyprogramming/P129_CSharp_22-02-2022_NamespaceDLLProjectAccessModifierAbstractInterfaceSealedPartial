using P129Interfce.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129Interfce.Models
{
    class Human : IWalk
    {
        public double Millage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Walk()
        {
            Console.WriteLine("Walk As human");
        }
    }
}
