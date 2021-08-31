using System;
using System.Collections.Generic;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private readonly ICollection<string> items;
        public Planet(string name, params string[] items)
        {
            this.Name = name;
            this.items = new List<string>(items);
        }
        public ICollection<string> Items 
        {
            get => this.items; 
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlanetName);
                }
                else
                {
                    this.name = value;
                }
            }
        }

    }
}
