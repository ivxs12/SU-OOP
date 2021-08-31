using System.Collections.Generic;

namespace MilitaryElite.Soldiers.Interfaces
{
    public interface ICommando
    {
        public List<Mission> Missions { get; set; }
        public decimal Salary { get; set; }
        public void AddMission(Mission mission);
        public string ToString();

    }
}
