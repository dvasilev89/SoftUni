using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class Ram : BaseProducts
    {
        private const double fixedWeight = 0.1;

        public Ram(double price, double weight) 
            : base(price, weight)
        {
            this.Weight = fixedWeight;
        }
    }
}
