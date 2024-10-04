using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class Truck : IVechicle
    {
        public float Payload { get; set; }
        public int Axles { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving a truck with {Payload} tons payload, which have {Axles} axles");
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling truck.");
        }
    }
}
