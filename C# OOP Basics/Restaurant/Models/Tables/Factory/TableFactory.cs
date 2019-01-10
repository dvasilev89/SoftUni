using SoftUniRestaurant.Models.Tables.Contracts;
using SoftUniRestaurant.Models.Tables.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Tables.Factory
{
    public static class TableFactory
    {
        public static ITable Create(string type, int tableNumber, int capacity)
        {  
            switch (type)
            {
                case "Inside":
                    return new InsideTable(tableNumber, capacity);
                case "Outside":
                    return new OutsideTable(tableNumber, capacity);
                default:
                    throw new ArgumentException($"{type} is not a valid Table");
            }
        }
    }
}
