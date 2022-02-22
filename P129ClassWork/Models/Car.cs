using System;
using System.Collections.Generic;
using System.Text;

namespace P129ClassWork.Models
{
    class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelFor1km { get; set; }

        public override void Drive(double km)
        {
            if ((km*FuelFor1km) <= CurrentFuel)
            {
                Millage += km;
                CurrentFuel -= (km * FuelFor1km);
                return;
            }
            Console.WriteLine("Bakda Yeteri Qeder Benzin Yoxdu");
        }
    }
}
