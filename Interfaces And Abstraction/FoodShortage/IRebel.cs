using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IRebel
    {
        public string Name { get; }
        public int Age { get; }
        public string Group { get; set; }
        public double Food { get; }
        public void AddFood();
    }
}
