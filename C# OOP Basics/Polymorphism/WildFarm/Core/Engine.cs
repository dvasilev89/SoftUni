using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factories;
using WildFarm.Interfaces;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private FoodFactory foodFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();                

                string type = animalInfo[0].ToLower();
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                Animal animal = animalFactory.CreateAnimal(animalInfo);
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());
                Food food = foodFactory.CreateFood(foodType, foodQuantity);

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }               

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
