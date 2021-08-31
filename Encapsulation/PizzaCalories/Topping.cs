using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Topping
    {
        private string type;
        private double caloriesForType;
        private const double baseCalories = 2;
        private double grams;
        private double total;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
            this.Total = (baseCalories * this.grams) * caloriesForType;
        }
        public string Type
        {
            private get => this.type;
            set
            {
                char[] type = value.ToCharArray();
                type[0] = char.ToUpper(type[0]);
                if (value == "meat")
                {
                    caloriesForType = 1.2;
                }
                else if (value == "veggies")
                {
                    caloriesForType = 0.8;
                }
                else if (value == "cheese")
                {
                    caloriesForType = 1.1;
                }
                else if (value == "sauce")
                {
                    caloriesForType = 0.9;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {new string(type)} on top of your pizza.");
                }
                this.type = new string(type);
            }
        }
        public double Total
        {
            get => this.total;
            set
            {
                this.total = value;
            }
        }
        public double Grams
        {
            set
            {
                if (value <= 50 && value >= 1)
                {
                    this.grams = value;
                }
                else
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50.]");
                }
            }
        }
    }
}
