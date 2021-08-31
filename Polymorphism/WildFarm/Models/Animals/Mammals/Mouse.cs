using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            base.allowedFood = new string[] { "Vegetable", "Fruit" };
            base.weightGain = 0.10;
            base.sound = "Squeak";
        }
    }
}
