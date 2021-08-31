using System.Text;
using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite.Soldiers
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; set; }
        public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.Append($"Code Number: {this.CodeNumber}");
            return sb.ToString();
        }
    }
}
