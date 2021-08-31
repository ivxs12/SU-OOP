using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Abstract;

namespace VehiclesExtension.Models
{
    class Bus : Vehicle
    {
        public Bus(double fuel, double consumption, double capacity) : base(fuel, consumption, capacity)
        {
            base.consumptionMultiplier = 1.4;
        }
    }
}
