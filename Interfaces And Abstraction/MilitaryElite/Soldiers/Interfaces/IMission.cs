namespace MilitaryElite.Soldiers.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }
        public void CompleteMission();
        public string ToString();
    }
}
