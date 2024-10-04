using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class TruckFactory : VechicleFactory
    {
        public override IVechicle CreateVechicle()
        {
            Console.WriteLine("Creating truck:");
            Console.WriteLine("Enter truck payload (tons):");
            float payload = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter axles count:");
            int axles = int.Parse(Console.ReadLine());
            return new Truck { Payload = payload, Axles = axles };
        }
    }
}
