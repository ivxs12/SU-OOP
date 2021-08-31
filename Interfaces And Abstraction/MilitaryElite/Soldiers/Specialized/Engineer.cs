using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; set; }
        public decimal Salary { get; set; }
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, corps)
        {
            this.Salary = salary;
            this.Repairs = new List<Repair>();
        } 
        public void AddTask(Repair repair)
        {
            this.Repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            if (this.Repairs.Count != 0)
            {
                sb.AppendLine($"Repairs:");
                for (int i = 0; i < this.Repairs.Count - 1; i++)
                {
                    sb.AppendLine($"  {this.Repairs[i].ToString()}");
                }
                sb.Append($"  {this.Repairs.Last()}");
            }
            else
            {
                sb.Append($"Repairs:");
            }
            return sb.ToString();
        }
    }
}
