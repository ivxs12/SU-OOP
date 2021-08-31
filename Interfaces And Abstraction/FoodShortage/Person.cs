using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    class Person : IPerson
    {
        private const double FoodIncrement = 10;
        public string Name { get; set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public string Birthday { get; }

        public double Food { get; private set; }

        public Person(string name, int age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = date;
        }
        public void AddFood()
        {
            this.Food += FoodIncrement;
        }
    }
}
