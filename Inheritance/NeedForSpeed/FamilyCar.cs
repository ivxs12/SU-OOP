﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override void Drive(int kilometers)
        {
            base.Drive(kilometers);
        }
    }
}
