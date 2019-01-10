using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Contracts;

namespace StorageMaster.Entities
{
    public abstract class BaseProducts : IProducts
    {
        private double price;
        private double weight;

        protected BaseProducts(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price
        {
            get { return price; }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }

                price = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
