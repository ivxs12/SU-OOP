using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            base.allowedFood = new string[] { "Meat" };
            base.weightGain = 0.25;
            base.sound = "Hoot Hoot";
        }
    }
}
