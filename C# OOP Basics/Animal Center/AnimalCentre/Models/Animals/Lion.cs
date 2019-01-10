﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models
{
    public class Lion : Animal
    {
        public Lion(string name, int energy, int happiness, int procedureTime) 
            : base(name, energy, happiness, procedureTime)
        {
        }

        public override string ToString()
        {
            return $"    Animal type: {GetType().Name.ToString()} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
