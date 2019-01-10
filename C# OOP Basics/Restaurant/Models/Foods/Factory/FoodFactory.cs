using SoftUniRestaurant.Models.Foods.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Foods.Factory
{
    public static class FoodFactory
    {
        public static IFood Create(string type, string name, decimal price)
        { 
            switch (type)
            {
                case "Dessert":
                    return new Dessert(name, price);
                case "Salad":
                    return new Salad(name, price);
                case "Soup":
                    return new Soup(name, price);
                case "MainCourse":
                    return new MainCourse(name, price);
                default:
                    throw new ArgumentException($"{type} is not a valid Food");
            }
        }
    }
}
