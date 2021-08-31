using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; }
        public string Id { get; }
        public string Birthday { get; }
        public double Food { get; }
        public void AddFood();
    }
}
