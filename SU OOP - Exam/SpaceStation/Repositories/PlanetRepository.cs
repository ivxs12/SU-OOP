using System.Collections.Generic;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly List<IPlanet> planets;
        public IReadOnlyCollection<IPlanet> Models { get { return planets.AsReadOnly(); } }
        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public void Add(IPlanet model)
        {
            planets.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            return planets.Find(x => x.Name == name);
        }

        public bool Remove(IPlanet model)
        {
            return planets.Remove(model);
        }
    }
}
