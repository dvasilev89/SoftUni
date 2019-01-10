using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class Gpu : BaseProducts
    {        
        private const double fixedWeight = 0.7;

        public Gpu(double price, double weight) 
            :base(price, weight)
       
        {
            this.Weight = fixedWeight;
        }
    }
}
