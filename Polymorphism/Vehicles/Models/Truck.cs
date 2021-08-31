using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    class Truck : IVehicle
    {
        private const double consumptionMultiplier = 1.6;
        private double fuelConsumption;
        public Truck(double fuel, double consumption)
        {
            this.FuelQuantity = fuel;
            this.FuelConsumption = consumption;
        }
        public double DistanceTravelled { get; private set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption
        {
            get => this.fuelConsumption;
            set
            {
                this.fuelConsumption = value + consumptionMultiplier;
            }
        }

        public void Drive(double distance)
        {
            if (this.FuelConsumption * distance < this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                this.DistanceTravelled += distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters * 0.95;
        }
        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }
}
