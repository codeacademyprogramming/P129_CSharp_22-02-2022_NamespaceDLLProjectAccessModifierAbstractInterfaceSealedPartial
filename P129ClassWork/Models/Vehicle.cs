using System;
using System.Collections.Generic;
using System.Text;

namespace P129ClassWork.Models
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public virtual string ShowInfo()
        {
            return $"Reng: {Color}\nBrand: {Brand}\nMillage: {Millage}";
        }

        public abstract void Drive(double km);
    }
}
