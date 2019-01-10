using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contracts
{
    public interface IProducts
    {
        double Price { get; }

        double Weight { get; }
    }
}
