﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public virtual void Drive(int kilometers)
        {
            this.Fuel = this.Fuel - (kilometers * this.FuelConsumption);
            Console.WriteLine(this.Fuel);
        }
    }
}
