using MilitaryElite.Soldiers.Interfaces;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecializedSoldier
    {
        public string Corps { get; set; }
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }
    }
}
