using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Abstract
{
    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Power { get; set; }
        public Hero(string name)
        {
            this.Name = name;
        }
        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name}";
        }
    }
}
