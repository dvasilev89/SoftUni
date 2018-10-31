using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] carInfo = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = carInfo[0];
                string plateNumber = carInfo[1];

                if (command == "IN")
                {
                    cars.Add(plateNumber);
                }
                else if (command == "OUT")
                {
                    cars.Remove(plateNumber);
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
