using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryElite.Soldiers;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Private> privs = new List<Private>();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Private":
                        Private priv = new Private(input[1], input[2], input[3], Convert.ToDecimal(input[4]));
                        if (!privs.Contains(priv))
                        {
                            Console.WriteLine(priv.ToString().Trim());
                            privs.Add(priv);
                        }
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral leutenant = new LieutenantGeneral(input[1], input[2], input[3], Convert.ToDecimal(input[4]));
                        for (int i = 5; i < input.Length; i++)
                        {
                            leutenant.AddPrivates(privs.Find(x => x.Id == input[i]));
                        }
                        leutenant.Privates = leutenant.Privates.OrderByDescending(x => x.Salary).ToList();
                        Console.WriteLine(leutenant.ToString().Trim());
                        break;
                    case "Engineer":
                        Engineer engineer = new Engineer(input[1], input[2], input[3], Convert.ToDecimal(input[4]), input[5]);
                        for (int i = 6; i < input.Length; i+=2)
                        {
                            Repair repair = new Repair(input[i], Convert.ToInt32(input[i + 1]));
                            engineer.AddTask(repair);
                        }
                        Console.WriteLine(engineer.ToString().Trim()); 
                        break;
                    case "Commando":
                        Commando commando = new Commando(input[1], input[2], input[3], Convert.ToDecimal(input[4]), input[5]);
                        for (int i = 6; i < input.Length; i += 2)
                        {
                            Mission mission = new Mission(input[i], input[i + 1]);
                            commando.AddMission(mission);
                        }
                        commando.Missions = commando.Missions.Where(x => x.State == "inProgress").ToList();
                        Console.WriteLine(commando.ToString().Trim()); 
                        break;
                    case "Spy":
                        Spy spy = new Spy(input[1], input[2], input[3], Convert.ToInt32(input[4]));
                        Console.WriteLine(spy.ToString().Trim()); 
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
