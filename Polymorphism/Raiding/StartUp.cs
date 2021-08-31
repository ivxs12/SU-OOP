using Raiding.Abstract;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();
            while (heroes.Count != n)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Paladin":
                        Hero paladin = new Paladin(name);
                        heroes.Add(paladin);
                        break;
                    case "Druid":
                        Hero druid = new Druid(name);
                        heroes.Add(druid);
                        break;
                    case "Warrior":
                        Hero warrior = new Warrior(name);
                        heroes.Add(warrior);
                        break;
                    case "Rogue":
                        Hero rogue = new Rogue(name);
                        heroes.Add(rogue);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }
            heroes.ForEach(x => Console.WriteLine(x.CastAbility()));
            long boss = int.Parse(Console.ReadLine());
            if (heroes.Sum(x => x.Power) >= boss)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
