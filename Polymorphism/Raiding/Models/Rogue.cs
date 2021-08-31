using Raiding.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            base.Power = 80;
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} hit for {this.Power} damage";
        }
    }
}
