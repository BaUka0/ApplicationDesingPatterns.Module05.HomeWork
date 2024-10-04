using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class Motorcycle : IVechicle
    {
        public string Type { get; set; }
        public float EngineCapacity { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving {Type} motorcycle with {EngineCapacity} engine.");
        }
        public void Refuel()
        {
            Console.WriteLine($"Refuel Motorcycle.");
        }
    }
}
