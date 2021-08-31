using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Rebel> rebels = new List<Rebel>();
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    Person person = new Person(input[0], Convert.ToInt32(input[1]), input[2], input[3]);
                    people.Add(person);
                }
                if (input.Length == 3)
                {
                    Rebel rebel = new Rebel(input[0], Convert.ToInt32(input[1]), input[2]);
                    rebels.Add(rebel);
                }
            }
            string names = Console.ReadLine();
            while (names != "End")
            {
                if (people.Exists(x => x.Name == names))
                {
                    people.Find(x => x.Name == names).AddFood();
                }
                if (rebels.Exists(x => x.Name == names))
                {
                    rebels.Find(x => x.Name == names).AddFood();
                }
                names = Console.ReadLine();
            }
            double foodSum = 0;
            people.ForEach(x => foodSum += x.Food);
            rebels.ForEach(x => foodSum += x.Food);
            Console.WriteLine(foodSum);
        }
    }
}
