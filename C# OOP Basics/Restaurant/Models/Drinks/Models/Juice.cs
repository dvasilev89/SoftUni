﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Drinks.Models
{
    public class Juice : Drink
    {
        private const decimal JuicePrice = 1.80M;

        public Juice(string name, int servingSize, string brand) 
            : base(name, servingSize, JuicePrice, brand)
        {
        }
    }
}
