using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; set; }
        public decimal Salary { get; set; }
        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, corps)
        {
            this.Salary = salary;
            this.Missions = new List<Mission>();
        }
        public void AddMission(Mission mission)
        {
            this.Missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            if (this.Missions.Count != 0)
            {
                sb.AppendLine($"Missions:");
                for (int i = 0; i < Missions.Count - 1; i++)
                {
                    sb.AppendLine($"  {this.Missions[i].ToString()}");
                }
                sb.Append($"  {this.Missions.Last()}");
            }
            else
            {
                sb.Append($"Missions:");
            }
            return sb.ToString();
        }
    }
}
