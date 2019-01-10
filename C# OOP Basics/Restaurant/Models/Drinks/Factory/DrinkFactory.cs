using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Drinks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Drinks.Factory
{
    public static class DrinkFactory
    {
        public static IDrink Create(string type, string name, int servingSize, string brand)
        {
            switch (type)
            {
                case "FuzzyDrink":
                    return new FuzzyDrink(name, servingSize, brand);
                case "Juice":
                    return new Juice(name, servingSize, brand);
                case "Water":
                    return new Water(name, servingSize, brand);
                case "Alcohol":
                    return new Alcohol(name, servingSize, brand);
                default:
                    throw new ArgumentException($"{type} is not a valid Drink");
            }
        }
    }
}
