namespace SpaceStation.Models.Astronauts
{
    public class Geodesist : Astronaut
    {
        private const double oxygen = 50;
        public Geodesist(string name) : base(name, oxygen)
        {
            this.Oxygen = oxygen;
        }
        public override void Breath()
        {
            base.Breath();
        }
    }
}
