using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorageMaster.Contracts;

namespace StorageMaster.Entities
{
    public abstract class BaseVehicles : IVehicles
    {
        private int capacity;
        private List<IProducts> trunk;
        private bool isFull;
        private bool isEmpty;

        public BaseVehicles(int capacity)
        {
            this.Capacity = capacity;
            this.Trunk = new List<IProducts>();           
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<IProducts> Trunk
        {
            get { return trunk; }
            set { trunk = value; }
        }        

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                if (trunk.Sum(x => x.Weight) >= capacity)
                {
                    isFull = true;
                }

                isFull = false;
            }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
            set
            {
                if (trunk.Count == 0)
                {
                    isEmpty = true;
                }

                isEmpty = false;
            }
        }        

        public void LoadProduct(IProducts product)
        {
            //TODO

            if (isFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public IProducts Unload()
        {
            if (isEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            IProducts result = trunk[trunk.Count - 1];
            trunk.RemoveAt(trunk.Count - 1);

            return result;
        }
    }
}
