using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Interfaces;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            string[] truckInfo = Console.ReadLine().Split();
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            string[] busInfo = Console.ReadLine().Split();
            IVehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));


            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] commandsArrgs = Console.ReadLine().Split();

                string command = commandsArrgs[0];
                string vehicle = commandsArrgs[1];

                try
                {
                    if (command == "Drive")
                    {
                        double distance = double.Parse(commandsArrgs[2]);

                        if (vehicle == "Car")
                        {
                            car.Drive(distance);
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Drive(distance);
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.isVehicleEmpty = false;
                            bus.Drive(distance);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(commandsArrgs[2]);

                        if (vehicle == "Car")
                        {
                            car.Refuel(fuel);
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(fuel);
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(fuel);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        double distance = double.Parse(commandsArrgs[2]);
                        bus.isVehicleEmpty = true;
                        bus.Drive(distance);
                    }

                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
