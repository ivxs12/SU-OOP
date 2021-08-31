﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Animals.Mammals
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; protected set; }
        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
