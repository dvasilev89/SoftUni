using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contracts
{
    public interface IVehicles
    {       
        int Capacity { get; }
        List<IProducts> Trunk { get; }
        bool IsFull { get; }
        bool IsEmpty { get; }

        void LoadProduct(IProducts product);

        IProducts Unload();
    }
}
