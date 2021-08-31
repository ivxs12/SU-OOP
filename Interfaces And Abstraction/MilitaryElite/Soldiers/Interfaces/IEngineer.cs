using System.Collections.Generic;

namespace MilitaryElite.Soldiers.Interfaces
{
    public interface IEngineer
    {
        public List<Repair> Repairs { get; set; }
        public decimal Salary { get; set; }
        public void AddTask(Repair repair);
        public string ToString();

    }
}
