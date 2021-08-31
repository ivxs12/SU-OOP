using System;
using System.Collections.Generic;
using System.Text;
using Raiding.Abstract;

namespace Raiding.Models
{
    class Druid : Hero
    {
        public Druid(string name) : base(name)
        {
            base.Power = 80;
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} healed for {this.Power}";
        }
    }
}
