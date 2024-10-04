using System;

namespace HomeWork_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vechicle type (Car, Motorcycle, Truck, Bus):");
            string input = Console.ReadLine();

            VechileType vechileType;
            if (Enum.TryParse(input, true, out vechileType))
            {
                IVechicle vechicle = GetVechicle(vechileType);
                vechicle.Drive();
                vechicle.Refuel();
            }
            else
            {
                throw new Exception("Invaid vechicle type!");
            }
        }
        public static IVechicle GetVechicle(VechileType type)
        {
            VechicleFactory factory = null;
            IVechicle vechicle = null;

            switch (type)
            {
                case VechileType.Car:
                    factory = new CarFactory();
                    break;
                case VechileType.Motorcycle:
                    factory = new MotorcycleFactory();
                    break;
                case VechileType.Truck:
                    factory = new TruckFactory();
                    break;
                case VechileType.Bus:
                    factory = new BusFactory();
                    break;
                default:
                    throw new Exception("Invalid document type!");
            }

            vechicle = factory.CreateVechicle();
            return vechicle;
        }
    }
}