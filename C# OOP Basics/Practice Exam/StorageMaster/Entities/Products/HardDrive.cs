using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class HardDrive : BaseProducts
    {
        private const double fixedWeight = 1;

        public HardDrive(double price, double weight) 
            : base(price, weight)
        {
            this.Weight = fixedWeight;
        }
    }
}
