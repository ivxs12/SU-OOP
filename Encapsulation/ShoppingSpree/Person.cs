using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }
        public string Name 
        {
            get => this.name; 
            private set
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "     ")
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        public decimal Money 
        {
            get => this.money; 
            set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }
        public List<Product> BagOfProducts { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (BagOfProducts.Count == 0)
            {
                sb.AppendLine($"{this.Name} - Nothing bought");
            }
            else
            {
                sb.Append($"{this.Name} - ");
                for (int i = 0; i < this.BagOfProducts.Count - 1; i++)
                {
                    sb.Append($"{this.BagOfProducts[i].Name}, ");
                }
                sb.Append($"{this.BagOfProducts.Last().Name}");
            }
            return sb.ToString();
        }
    }
}
