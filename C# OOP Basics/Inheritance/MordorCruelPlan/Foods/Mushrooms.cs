﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan.Foods
{
    public class Mushrooms : Food
    {
        private const int happiness = -10;

        public Mushrooms()
            : base(happiness)
        {
        }
    }
}
