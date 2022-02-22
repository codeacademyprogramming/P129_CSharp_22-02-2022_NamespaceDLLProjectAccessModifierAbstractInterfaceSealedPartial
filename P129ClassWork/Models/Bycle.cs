using System;
using System.Collections.Generic;
using System.Text;

namespace P129ClassWork.Models
{
    class Bycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
