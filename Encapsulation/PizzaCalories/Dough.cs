using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Dough
    {
        private double total;
        private const double baseCaloriesDough = 2;
        private double caloriesPerGramFlour;
        private double caloriesPerGramTechnique;
        private double grams;

        public Dough(string flour, string technique, double grams)
        {
            this.Flour = flour;
            this.BakingTechnique = technique;
            this.Grams = grams;
            this.Total = (baseCaloriesDough * this.grams) * caloriesPerGramFlour * caloriesPerGramTechnique;
        }
        public string Flour
        {
            set
            {
                if (value == "white")
                {
                    caloriesPerGramFlour = 1.5;
                }
                else if (value == "wholegrain")
                {
                    caloriesPerGramFlour = 1;
                } 
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            set
            {
                if (value == "crispy")
                {
                    caloriesPerGramTechnique = 0.9;
                }
                if (value == "chewy")
                {
                    caloriesPerGramTechnique = 1.1;
                }
                if (value == "homemade")
                {
                    caloriesPerGramTechnique = 1;
                }
            }
        }
        public double Grams
        {
            set
            {
                if (value <= 200 && value >= 1)
                {
                    this.grams = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
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
    }
}
