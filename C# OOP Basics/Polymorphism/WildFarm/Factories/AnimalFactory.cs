using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string[] animalInfo)
        {
            string type = animalInfo[0].ToLower();
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            switch (type)
            {
                case "owl":
                    return new Owl(name, weight, double.Parse(animalInfo[3]));
                case "hen":
                    return new Hen(name, weight, double.Parse(animalInfo[3]));
                case "cat":
                    return new Cat(name, weight, animalInfo[3], animalInfo[4]);
                case "tiger":
                    return new Tiger(name, weight, animalInfo[3], animalInfo[4]);
                case "dog":
                    return new Dog(name, weight, animalInfo[3]);
                case "mouse":
                    return new Mouse(name, weight, animalInfo[3]);
                default:
                    throw new ArgumentException($"{type} is not a valid Animal type.");
            }
        }
    }
}
