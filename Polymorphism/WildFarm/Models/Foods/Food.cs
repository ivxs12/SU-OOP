using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Foods
{
    public class Food
    {
        public int Quantity { get; set; }
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
