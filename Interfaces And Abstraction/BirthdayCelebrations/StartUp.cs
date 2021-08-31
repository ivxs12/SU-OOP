using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<int, Person> people = new Dictionary<int, Person>();
            Dictionary<int, Robot> robots = new Dictionary<int, Robot>();
            Dictionary<int, Pet> pets = new Dictionary<int, Pet>();

            int count = 1;
            while (input[0] != "End")
            {
                if (input[0] == "Citizen")
                {
                    Person person = new Person(input[1], Convert.ToInt32(input[2]), input[3], input[4]);
                    people.Add(count, person);
                }
                if (input[0] == "Robot")
                {
                    Robot robot = new Robot(input[0], input[1]);
                    robots.Add(count, robot);
                }
                if (input[0] == "Pet")
                {
                    Pet pet = new Pet(input[1], input[2]);
                    pets.Add(count, pet);
                }
                count++;
                input = Console.ReadLine().Split();
            }
            string filter = Console.ReadLine();
            people = people.Where(x => x.Value.Birthday.EndsWith(filter)).ToDictionary(x => x.Key, x => x.Value);
            pets = pets.Where(x => x.Value.Birthday.EndsWith(filter)).ToDictionary(x => x.Key, x => x.Value);

            if (people.Count == 0 && pets.Count == 0)
            {
                return;
            }
            for (int i = 0;  i < count; i++)
            {
                if (people.ContainsKey(i))
                {
                    Console.WriteLine(people[i].Birthday);
                }
                if (pets.ContainsKey(i))
                {
                    Console.WriteLine(pets[i].Birthday);                   
                }
            }
        }
    }
}
