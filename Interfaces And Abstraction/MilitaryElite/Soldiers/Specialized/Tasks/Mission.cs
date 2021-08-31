using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
