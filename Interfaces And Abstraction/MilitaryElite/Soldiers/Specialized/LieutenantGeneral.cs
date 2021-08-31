using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite
{
    public class LieutenantGeneral : Soldier, ILieutenantGeneral
    {
        public List<Private> Privates { get; set; }
        public decimal Salary { get; set; }
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Privates = new List<Private>();
        }
        public void AddPrivates(Private priv)
        {
            this.Privates.Add(priv);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            if (this.Privates.Count != 0)
            {
                sb.AppendLine($"Privates:");
                for (int i = 0; i < this.Privates.Count - 1; i++)
                {
                    sb.AppendLine($"  {this.Privates[i].ToString()}");
                }
                sb.Append($"  {this.Privates.Last()}");
            }
            else
            {
                sb.Append($"Privates:");
            }
            return sb.ToString();
        }
    }
}
