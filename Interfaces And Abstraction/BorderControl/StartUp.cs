using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<int, Person> people = new Dictionary<int, Person>();
            Dictionary<int, Robot> robots = new Dictionary<int, Robot>();

            int count = 1;
            while (input[0] != "End")
            {
                if (input.Length == 3)
                {
                    Person person = new Person(input[0], Convert.ToInt32(input[1]), input[2]);
                    people.Add(count, person);
                }
                if (input.Length == 2)
                {
                    Robot robot = new Robot(input[0], input[1]);
                    robots.Add(count, robot);
                }
                count++;
                input = Console.ReadLine().Split();
            }
            string filter = Console.ReadLine();
            people = people.Where(x => x.Value.Id.EndsWith(filter)).ToDictionary(x => x.Key, x => x.Value);
            robots = robots.Where(x => x.Value.Id.EndsWith(filter)).ToDictionary(x => x.Key, x => x.Value);

            for (int i = 0;  i < count; i++)
            {
                if (people.ContainsKey(i))
                {
                    Console.WriteLine(people[i].Id);
                }
                if (robots.ContainsKey(i))
                {
                    Console.WriteLine(robots[i].Id);
                }
            }
        }
    }
}
