using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class Bus : IVechicle
    {
        public int Seats { get; set; }
        public string Route { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving bus, which have {Seats} seats by {Route} route.");
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling bus.");
        }
    }
}
