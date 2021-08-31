using System;
using VehiclesExtension.Models;
using VehiclesExtension.Abstract;

namespace VehiclesExtension
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Vehicle car = new Car(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]), Convert.ToDouble(input[3]));

            input = Console.ReadLine().Split();
            Vehicle truck = new Truck(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]), Convert.ToDouble(input[3]));

            input = Console.ReadLine().Split();
            Vehicle bus = new Bus(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]), Convert.ToDouble(input[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split();
                try
                {
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
                            if (input[1] == "Bus")
                            {
                                bus.Drive(Convert.ToDouble(input[2]));
                            }
                            break;
                        case "Refuel":
                            if (input[1] == "Car")
                            {
                                car.Refuel(Convert.ToDouble(input[2]));
                            }
                            if (input[1] == "Truck")
                            {
                                truck.Refuel(Convert.ToDouble(input[2]), 0.95);
                            }
                            if (input[1] == "Bus")
                            {
                                bus.Refuel(Convert.ToDouble(input[2]));
                            }
                            break;
                        case "DriveEmpty":
                            bus.DriveEmpty(Convert.ToDouble(input[2]));
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
