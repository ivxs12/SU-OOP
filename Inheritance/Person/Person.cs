using System;
using System.Text;

namespace Person
{
    class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age 
        { 
            get => this.age;
            set
            {
                this.age = value;
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            return sb.ToString();
        }
    }
}
