using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals
{
    class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
            base.allowedFood = new string[] { "Meat", "Vegetable" };
            base.weightGain = 0.30;
            base.sound = "Meow";
        }
    }
}
