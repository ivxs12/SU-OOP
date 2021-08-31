using System.Collections.Generic;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        private List<string> itemsToRemove = new List<string>();
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (IAstronaut astronaut in astronauts)
            {
                foreach (string item in planet.Items)
                {
                    if (astronaut.CanBreath)
                    {
                        astronaut.Breath();
                        astronaut.Bag.Items.Add(item);
                        itemsToRemove.Add(item);
                    }
                }
                foreach (var item in itemsToRemove)
                {
                    planet.Items.Remove(item);
                }
                itemsToRemove = new List<string>();
            }
        }
    }
}
