﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IRobot
    {
        public string Model { get; }
        public string Id { get; }
    }
}
