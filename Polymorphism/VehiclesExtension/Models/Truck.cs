using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Abstract;

namespace VehiclesExtension.Models
{
    class Truck : Vehicle
    {
        public Truck(double fuel, double consumption, double capacity) : base(fuel, consumption, capacity)
        {
            base.consumptionMultiplier = 1.6;
        }
    }
}
