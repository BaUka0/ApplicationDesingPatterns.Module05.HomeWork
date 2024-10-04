using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class CarFactory : VechicleFactory
    {
        public override IVechicle CreateVechicle()
        {
            Console.WriteLine("Creating a car:");
            Console.WriteLine("Enter car brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter car model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter fuel type:");
            string fuelType = Console.ReadLine();
            return new Car { Brand = brand, Model = model, FuelType = fuelType };
        }
    }
}
