using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Abstract;

namespace Raiding.Models
{
    class Paladin : Hero
    {
        public Paladin(string name) : base(name)
        {
            base.Power = 100;
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} healed for {this.Power}";
        }
    }
}
