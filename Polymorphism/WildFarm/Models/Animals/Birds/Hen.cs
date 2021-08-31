using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals
{
    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            base.weightGain = 0.35;
            base.sound = "Cluck";
        }
    }
}
