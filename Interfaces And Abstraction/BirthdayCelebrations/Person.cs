using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthday { get; private set; }
        public Person(string name, int age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = date;
        }
    }
}
