using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    class Product
    {
        private string name;
        private decimal price;
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
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
        public decimal Price
        {
            get { return this.price; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.price = value;
            }

        }
    }
}
