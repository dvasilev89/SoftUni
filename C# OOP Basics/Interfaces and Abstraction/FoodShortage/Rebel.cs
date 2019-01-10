﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
