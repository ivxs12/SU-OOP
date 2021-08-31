using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Abstract
{
    public abstract class Vehicle
    {
        protected double consumptionMultiplier;
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }
        public double DistanceTravelled { get; private set; }
        protected Vehicle(double fuel, double consumption, double capacity)
        {
            this.FuelQuantity = fuel;
            this.FuelConsumption = consumption;
            this.TankCapacity = capacity;
            this.FuelQuantity = fuel > TankCapacity ? 0 : fuel;
        }
        public void Drive(double distance)
        {
            if ((this.FuelConsumption + this.consumptionMultiplier) * distance < this.FuelQuantity)
            {
                this.FuelQuantity -= (this.FuelConsumption + consumptionMultiplier) * distance;
                this.DistanceTravelled += distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public void DriveEmpty(double distance)
        {
            if (this.FuelConsumption * distance < this.FuelQuantity)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                this.DistanceTravelled += distance;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            this.FuelQuantity += liters;
        }
        public void Refuel(double liters, double hole)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            this.FuelQuantity += liters * hole;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
