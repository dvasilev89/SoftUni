using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public class Pig : Animal
    {
        public Pig(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return $"    Animal type: {GetType().Name.ToString()} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
