using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm.Interfaces
{
    public interface IAnimal
    {        
        string Name { get; set; }
        double Weight { get; set; }
        int FoodEaten { get; set; }

        string ProduceSound();        

        void EatFood(Food food);
    }
}
