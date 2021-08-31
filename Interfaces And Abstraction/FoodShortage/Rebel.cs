using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    class Rebel : IRebel
    {
        private const double FoodIncrement = 5;
        public string Name { get; }

        public int Age { get; }

        public string Group { get; set; }
        public double Food { get; private set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public void AddFood()
        {
            this.Food += FoodIncrement;
        }
    }
}
