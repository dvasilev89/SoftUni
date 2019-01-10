using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public abstract class Hotel : IHotel
    {
        private int capacity;
        private Dictionary<string, IAnimal> animals;

        public Hotel()
        {
            this.Animals = new Dictionary<string, IAnimal>();
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Dictionary<string, IAnimal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }        

        public void Accommodate(IAnimal animal)
        {
            IAnimal anima2l = new Cat("Gogo", 50, 20, 60);
        }

        public void Adopt(string animalName, string owner)
        {
            throw new ArgumentException("Fuck Off");
        }
    }
}
