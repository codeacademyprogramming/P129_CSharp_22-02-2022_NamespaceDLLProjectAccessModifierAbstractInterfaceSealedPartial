using P129ClassWork.Models;
using System;

namespace P129ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "BMW";
            car.Color = "Milioner";
            car.FuelFor1km = 5;
            car.FuelCapacity = 250;
            car.CurrentFuel = 250;

            Console.WriteLine($"{car.ShowInfo()}\nFuel " +
                $"Capacity: {car.FuelCapacity}\nFuel For 1 Km: {car.FuelFor1km}\nCurrent Fuel: {car.CurrentFuel} ");

            car.Drive(10);
            car.Drive(15);
            car.Drive(20);

            Console.WriteLine($"{car.ShowInfo()}\nFuel " +
                $"Capacity: {car.FuelCapacity}\nFuel For 1 Km: {car.FuelFor1km}\nCurrent Fuel: {car.CurrentFuel} ");

            Bycle bycle = new Bycle();

            bycle.Drive(25);
        }
    }
}
