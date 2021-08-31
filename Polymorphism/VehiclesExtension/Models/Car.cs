using System;
using System.Collections.Generic;
using System.Text;
using VehiclesExtension.Abstract;

namespace VehiclesExtension.Models
{
    class Car : Vehicle
    {
        public Car(double fuel, double consumption, double capacity) : base(fuel, consumption, capacity)
        {
            base.consumptionMultiplier = 0.9;
        }
    }
}
