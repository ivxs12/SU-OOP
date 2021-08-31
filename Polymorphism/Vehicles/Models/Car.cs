using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    class Car : IVehicle
    {
        private const double consumptionMultiplier = 0.9;
        private double fuelConsumption;

        public Car(double fuel, double consumption)
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
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
