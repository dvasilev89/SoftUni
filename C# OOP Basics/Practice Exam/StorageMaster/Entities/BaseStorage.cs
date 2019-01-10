using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorageMaster.Contracts;

namespace StorageMaster.Entities
{
    public abstract class BaseStorage : IStorage
    {
        private string name;
        private int capacity;
        private int garageSlots;
        private bool isFull;
        private List<IVehicles> garage;
        private List<IProducts> products;

        public BaseStorage(string name, int capacity, int garageSlots, IEnumerable<IVehicles> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.Garage = new List<IVehicles>();
            this.Products = new List<IProducts>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }

        public bool IsFull
        {
            get { return isFull; }
            set
            {
                if (products.Sum(x => x.Weight) >= capacity)
                {
                    isFull = true;
                }

                isFull = false;
            }
        }

        public List<IVehicles> Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public List<IProducts> Products
        {
            get { return products; }
            set { products = value; }
        }


        public IVehicles GetVehicle(int garageSlot)
        {
            if (garageSlot >= GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            else if (garage.ElementAt(garageSlot) == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return garage.ElementAt(garageSlot);
        }

        public int SendVehicleTo(int garageSlot, IStorage deliveryLocation)
        {
            IVehicles vehicle = GetVehicle(garageSlot);
            
            if (garage.Contains(null) == false)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            return 3;

            //Then, the method checks if there are any free garage slots.A free garage slot is denoted by a null value.
            //If there is no free garage slot, throw an InvalidOperationException with the message "No room in garage!".
            //Then, the garage slot in the source storage is freed and the vehicle is added to the first free garage slot.
            //The method returns the garage slot the vehicle was assigned when it was transferred.



        }

        public int UnloadVehicle(int garageSlot)
        {
            throw new NotImplementedException();
        }
    }
}
