using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class BusFactory : VechicleFactory
    {
        public override IVechicle CreateVechicle()
        {
            Console.WriteLine("Creating bus:");
            Console.WriteLine("Enter seats count:");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter route");
            string route = Console.ReadLine();
            return new Bus { Seats = seats, Route = route };
        }
    }
}
