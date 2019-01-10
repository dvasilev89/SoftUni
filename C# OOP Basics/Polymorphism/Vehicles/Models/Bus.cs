using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public class Bus : Vehicle, IBus
    {
        private const double airConditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumption = FuelConsumption;

            if (!isVehicleEmpty)
            {
                currentFuelConsumption += airConditionConsumption;
            }

            double neededFuel = distance * currentFuelConsumption;

            if (neededFuel < FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
    }
}
