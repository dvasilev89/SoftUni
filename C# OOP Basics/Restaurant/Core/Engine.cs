using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniRestaurant.Core
{
    public class Engine
    {
        RestaurantController restaurantController = new RestaurantController();

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                List<string> args = input.Split().ToList();
                string command = args[0];
                args.RemoveAt(0);
                string result = string.Empty;

                try
                {
                    switch (command)
                    {
                        case "AddFood":
                            string type = args[0];
                            string name = args[1];
                            decimal price = decimal.Parse(args[2]);
                            result = restaurantController.AddFood(type, name, price);
                            break;
                        case "AddDrink":
                            int servingSize = int.Parse(args[2]);
                            string brand = args[3];
                            result = restaurantController.AddDrink(args[0], args[1], servingSize, brand);
                            break;
                        case "AddTable":
                            int tableNumber = int.Parse(args[1]);
                            int capacity = int.Parse(args[2]);
                            result = restaurantController.AddTable(args[0], tableNumber, capacity);
                            break;
                        case "ReserveTable":
                            int numberOfPeople = int.Parse(args[0]);
                            result = restaurantController.ReserveTable(numberOfPeople);
                            break;
                        case "OrderFood":
                            int tn = int.Parse(args[0]);
                            string foodName = args[1];
                            result = restaurantController.OrderFood(tn, foodName);
                            break;
                        case "OrderDrink":
                            int tn2 = int.Parse(args[0]);
                            string drinkName = args[1];
                            string drinkBrand = args[2];
                            result = restaurantController.OrderDrink(tn2, drinkName, drinkBrand);
                            break;
                        case "LeaveTable":
                            int tn3 = int.Parse(args[0]);
                            result = restaurantController.LeaveTable(tn3);
                            break;
                        case "GetFreeTablesInfo":
                            result = restaurantController.GetFreeTablesInfo();
                            break;
                        case "GetOccupiedTablesInfo":
                            result = restaurantController.GetOccupiedTablesInfo();
                            break;
                        default:
                            throw new ArgumentException($"{command} is an invalid command!");
                    }
                }

                catch (ArgumentException ae)
                {

                    Console.Write(ae.Message);
                }                

                Console.WriteLine(result);

                input = Console.ReadLine();

                if (input == "END")
                {
                    Console.WriteLine(restaurantController.GetSummary());
                }
            }
        }
    }
}
