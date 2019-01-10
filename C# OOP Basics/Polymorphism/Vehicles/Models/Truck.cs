using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle, ITruck
    {
        private const double airConditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += airConditionConsumption;            
        }

        public override void Refuel(double fuel)
        {
            if (fuel < 1)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (TankCapacity < FuelQuantity + fuel)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            FuelQuantity += fuel * 0.95;
        }
    }
}
