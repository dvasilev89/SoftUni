﻿using System;
using System.Collections.Generic;
using System.Text;
using MordorCruelPlan.Foods;

namespace MordorCruelPlan.Factories
{
    public class FoodFactory
    {
        public Food CreateFood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Junk();
            }
        }
    }
}
