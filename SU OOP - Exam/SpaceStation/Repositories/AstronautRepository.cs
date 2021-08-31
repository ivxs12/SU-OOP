using System.Collections.Generic;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Models.Astronauts.Contracts;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private readonly List<IAstronaut> astronauts;
        public IReadOnlyCollection<IAstronaut> Models { get { return astronauts.AsReadOnly(); } }
        public AstronautRepository()
        {
            this.astronauts = new List<IAstronaut>();
        }

        public void Add(IAstronaut model)
        {
            astronauts.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            if (astronauts.Exists(x => x.Name == name))
            {
                return astronauts.Find(x => x.Name == name);
            }
            else
            {
                return null;
            }
        }

        public bool Remove(IAstronaut model)
        {
            return astronauts.Remove(model);
        }
    }
}
