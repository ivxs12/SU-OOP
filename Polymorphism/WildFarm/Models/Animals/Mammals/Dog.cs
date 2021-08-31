using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals
{
    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            base.allowedFood = new string[] { "Meat" };
            base.weightGain = 0.40;
            base.sound = "Woof!";
        }
    }
}
