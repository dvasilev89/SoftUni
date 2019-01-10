using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan.Foods
{
    public abstract class Food
    {
        public Food(int happiness)
        {
            Happiness = happiness;
        }

        public int Happiness { get; private set; }
    }
}
