﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan.Foods
{
    public class Lembas : Food
    {
        private const int happiness = 3;

        public Lembas() 
            : base(happiness)
        {
        }
    }
}
