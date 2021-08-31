using System;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags.Contracts;
using SpaceStation.Utilities.Messages;
using SpaceStation.Models.Bags;

namespace SpaceStation.Models
{
    public abstract class Astronaut : IAstronaut 
    {
        private string name;
        private double oxygen;
        private readonly IBag bag;
        public Astronaut(string name, double oxygen)
        {
            this.Oxygen = oxygen;
            this.Name = name;
            this.bag = new Backpack();
        }

        public string Name
        {
            get => this.name;
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAstronautName);
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public double Oxygen
        {
            get => this.oxygen;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOxygen);
                }
                else
                {
                    this.oxygen = value;
                }
            }
        }
        public bool CanBreath
        {
            get => this.Oxygen > 0;
        }
        public IBag Bag
        {
            get => this.bag;
        }
        public virtual void Breath()
        {
            if (this.Oxygen >= 10)
            {
                this.Oxygen -= 10;
            }
        }
    }
}
