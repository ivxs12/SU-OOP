namespace MilitaryElite.Soldiers.Interfaces
{
    public interface IRepair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }
        public string ToString();
    }
}
