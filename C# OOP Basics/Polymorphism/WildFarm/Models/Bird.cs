using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
