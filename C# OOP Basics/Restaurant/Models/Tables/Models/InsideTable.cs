﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Tables.Models
{
    public class InsideTable : Table
    {
        private const decimal InitialPricePerPerson = 2.50M;

        public InsideTable(int tableNumber, int capacity) 
            : base(tableNumber, capacity, InitialPricePerPerson)
        {
        }
    }
}
