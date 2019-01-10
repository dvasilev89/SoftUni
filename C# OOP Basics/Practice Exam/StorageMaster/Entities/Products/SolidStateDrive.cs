using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class SolidStateDrive : BaseProducts
    {
        private const double fixedWeight = 0.2;

        public SolidStateDrive(double price, double weight) 
            : base(price, weight)
        {
            this.Weight = fixedWeight;
        }
    }
}
