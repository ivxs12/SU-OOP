using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public Person(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}
