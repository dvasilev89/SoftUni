using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>(); 

            while (true)
            {
                
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] animalInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                try
                {
                    switch (animalType)
                    {
                        case "Cat":
                            animals.Add(new Cat(name, age, gender)); break;
                        case "Dog":
                            animals.Add(new Dog(name, age, gender)); break;
                        case "Frog":
                            animals.Add(new Frog(name, age, gender)); break;
                        case "Kitten":
                            animals.Add(new Kitten(name, age)); break;
                        case "Tomcat":
                            animals.Add(new Tomcat(name, age)); break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
