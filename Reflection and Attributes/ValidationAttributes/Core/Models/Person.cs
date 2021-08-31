using ValidationAttributes.Core.Contracts;
using ValidationAttributes.Core.Atributes;

namespace ValidationAttributes.Core.Models
{
    class Person : IPerson
    {
        [MyRequired]
        public string Name { get; }
        [MyRange(12, 90)]
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
