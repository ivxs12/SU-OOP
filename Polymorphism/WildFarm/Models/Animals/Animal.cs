using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal
    {
        protected string sound;
        protected double weightGain;
        protected string[] allowedFood = { "Fruit", "Meat", "Seeds", "Vegetable" }; 
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public void Eat(Food food)
        {
            if (allowedFood.Contains(food.GetType().Name))
            {
                this.Weight += this.weightGain * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
        public string Speak()
        {
            return $"{this.sound}";
        }
    }
}
