using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Contracts
{
    public interface IStorage
    {
        string Name { get; }
        int Capacity { get; }
        int GarageSlots { get; }
        bool IsFull { get; }
        List<IVehicles> Garage { get; }
        List<IProducts> Products { get; }

        IVehicles GetVehicle(int garageSlot);

        int SendVehicleTo(int garageSlot, IStorage deliveryLocation);

        int UnloadVehicle(int garageSlot);
    }
}
