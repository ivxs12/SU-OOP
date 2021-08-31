using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals
{
    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            base.allowedFood = new string[] { "Meat" };
            base.weightGain = 1;
            base.sound = "ROAR!!!";
        }
    }
}
