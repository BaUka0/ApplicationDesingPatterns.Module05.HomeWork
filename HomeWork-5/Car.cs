using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class Car : IVechicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving a {Brand} {Model} car.");
        }
        public void Refuel()
        {
            Console.WriteLine($"Refueling a {Brand} {Model} car with {FuelType}.");
        }
    }
}
