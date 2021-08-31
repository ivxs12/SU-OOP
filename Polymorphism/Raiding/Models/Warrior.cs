using Raiding.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            base.Power = 100;
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} hit for {this.Power} damage";
        }
    }
}
