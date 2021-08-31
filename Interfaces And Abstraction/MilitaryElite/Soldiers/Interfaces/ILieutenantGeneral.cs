using System.Collections.Generic;

namespace MilitaryElite.Soldiers.Interfaces
{
    public interface ILieutenantGeneral
    {
        public List<Private> Privates { get; set; }
        public decimal Salary { get; set; }
        public void AddPrivates(Private priv);
        public string ToString();
    }
}
