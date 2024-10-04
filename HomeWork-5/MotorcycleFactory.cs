using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class MotorcycleFactory : VechicleFactory
    {
        public override IVechicle CreateVechicle()
        {
            Console.WriteLine("Creating motorcycle:");
            Console.WriteLine("Enter motorcycle type:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter engine capacity:");
            float engineCapacity = float.Parse(Console.ReadLine());
            return new Motorcycle { Type = type, EngineCapacity = engineCapacity };
        }
    }
}
