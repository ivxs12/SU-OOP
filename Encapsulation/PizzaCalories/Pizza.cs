using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private int countToppings;
        private double totalCalories;
        public Dough Dough { get; set; }

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15 || value.Length < 1)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        protected List<Topping> Toppings
        {
            private get => this.toppings;
            set
            {
                this.toppings = value;
            }
        }
        protected double TotalCalories
        {
            get => this.totalCalories;
            private set
            {
                this.totalCalories = value;
            }
        }
        public int CountToppings
        {
            get => this.countToppings;
            private set
            {
                this.countToppings = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count > 10 || this.Toppings.Count < 0)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.Toppings.Add(topping);
            this.countToppings++;
        }
        private double ToppingsTotal()
        {
            double sum = 0;
            foreach (Topping topping in this.Toppings)
            {
                sum += topping.Total;
            }
            return sum;
        }
        public double PizzaTotal()
        {
            return this.ToppingsTotal() + this.Dough.Total;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.PizzaTotal():f2} Calories.";
        }

    }
}
