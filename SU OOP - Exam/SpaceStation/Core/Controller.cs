using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SpaceStation.Core.Contracts;
using SpaceStation.Utilities.Messages;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Mission;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private int countExplored = 0;
        private readonly IRepository<IAstronaut> astronauts = new AstronautRepository();
        private readonly IRepository<IPlanet> planets = new PlanetRepository();

        public Controller()
        {

        }
        public string AddAstronaut(string type, string astronautName)
        {
            if (type == "Biologist" || type == "Geodesist" || type == "Meteorologist")
            {
                if (type == "Biologist")
                {
                    IAstronaut astronaut = new Biologist(astronautName);
                    astronauts.Add(astronaut);
                    return $"Successfully added {type}: {astronautName}!";
                }
                if (type == "Geodesist")
                {
                    IAstronaut astronaut = new Geodesist(astronautName);
                    astronauts.Add(astronaut);
                    return $"Successfully added {type}: {astronautName}!";
                }
                if (type == "Meteorologist")
                {
                    IAstronaut astronaut = new Meteorologist(astronautName);
                    astronauts.Add(astronaut);
                    return $"Successfully added {type}: {astronautName}!";
                }
            }
            throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName, items);
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            List<IAstronaut> missionAstronauts = astronauts.Models.Where(x => x.Oxygen > 60).ToList();
            List<IAstronaut> deadAstronauts;
            
            if (missionAstronauts.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }
            else
            {
                IMission mission = new Mission();
                mission.Explore(planets.FindByName(planetName), missionAstronauts);
                deadAstronauts = missionAstronauts.Where(x => x.CanBreath == false).ToList();
                countExplored += 1;
                return $"Planet: {planetName} was explored! Exploration finished with {deadAstronauts.Count} dead astronauts!";
            }
        }

        public string Report()
        {
            List<IAstronaut> astronautsList = astronauts.Models.ToList(); 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{countExplored} planets were explored!");
            sb.AppendLine("Astronauts info:");
            foreach (IAstronaut astronaut in astronautsList)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine($"Bag items: none");
                }
                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}".Trim());
                }
            }
            return sb.ToString().Trim();
        }

        public string RetireAstronaut(string astronautName)
        {
            if (astronauts.FindByName(astronautName) == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
            else
            {
                astronauts.Remove(astronauts.FindByName(astronautName));
                return $"Astronaut {astronautName} was retired!";
            }
        }
    }
}
