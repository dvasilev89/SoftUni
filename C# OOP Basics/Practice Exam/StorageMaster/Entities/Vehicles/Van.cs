using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public class Van : BaseVehicles
    {
        private const int fixedCapacity = 2;

        public Van(int capacity) 
            : base(capacity)
        {
            this.Capacity = fixedCapacity;
        }
    }
}
