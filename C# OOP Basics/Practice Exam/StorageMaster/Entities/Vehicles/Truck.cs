using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public class Truck : BaseVehicles
    {
        private const int fixedCapacity = 5;

        public Truck(int capacity) 
            : base(capacity)
        {
            this.Capacity = fixedCapacity;
        }
    }
}
