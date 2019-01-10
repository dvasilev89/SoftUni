using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public class Semi : BaseVehicles
    {
        private const int fixedCapacity = 10;

        public Semi(int capacity) 
            : base(capacity)
        {
            this.Capacity = fixedCapacity;
        }
    }
}
