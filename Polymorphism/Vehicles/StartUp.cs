using System;
using Vehicles.Models;
using Vehicles.Interfaces;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            IVehicle car = new Car(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));

            input = Console.ReadLine().Split();
            IVehicle truck = new Truck(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "Drive":
                        if (input[1] == "Car")
                        {
                            car.Drive(Convert.ToDouble(input[2]));
                        }
                        if (input[1] == "Truck")
                        {
                            truck.Drive(Convert.ToDouble(input[2]));
                        }
                        break;
                    case "Refuel":
                        if (input[1] == "Car")
                        {
                            car.Refuel(Convert.ToDouble(input[2]));
                        }
                        if (input[1] == "Truck")
                        {
                            truck.Refuel(Convert.ToDouble(input[2]));
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
