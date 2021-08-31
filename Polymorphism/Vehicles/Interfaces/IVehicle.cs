﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double distance);
        public void Refuel(double liters);
        public string ToString();
    }
}
