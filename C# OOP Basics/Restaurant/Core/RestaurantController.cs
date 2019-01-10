namespace SoftUniRestaurant.Core
{
    using SoftUniRestaurant.Models.Drinks.Contracts;
    using SoftUniRestaurant.Models.Drinks.Factory;
    using SoftUniRestaurant.Models.Foods.Contracts;
    using SoftUniRestaurant.Models.Foods.Factory;
    using SoftUniRestaurant.Models.Tables.Contracts;
    using SoftUniRestaurant.Models.Tables.Factory;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class RestaurantController
    {
        private List<IFood> menu;
        private List<IDrink> drinks;
        private List<ITable> tables;
        private decimal totalIncome = 0.0M;

        public RestaurantController()
        {
            this.menu = new List<IFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }

        public string AddFood(string type, string name, decimal price)
        {
            IFood food = FoodFactory.Create(type, name, price);

            if (food != null)
            {
                menu.Add(food);
                return $"Added {food.Name} ({food.GetType().Name.ToString()}) with price {food.Price:f2} to the pool";
            }

            return string.Empty;
        }

        public string AddDrink(string type, string name, int servingSize, string brand)
        {
            IDrink drink = DrinkFactory.Create(type, name, servingSize, brand);

            if (drink != null)
            {
                drinks.Add(drink);
                return $"Added {drink.Name} ({drink.Brand}) to the drink pool";
            }

            return string.Empty;
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = TableFactory.Create(type, tableNumber, capacity);

            if (table != null)
            {
                tables.Add(table);
                return $"Added table number {table.TableNumber} in the restaurant";
            }

            return string.Empty;
        }

        public string ReserveTable(int numberOfPeople)
        {
            foreach (var table in tables)
            {
                if (table.IsReserved == false && table.Capacity >= numberOfPeople)
                {
                    table.IsReserved = true;
                    table.NumberOfPeople = numberOfPeople;
                    return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
                }
            }

            return $"No available table for {numberOfPeople} people";
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable currentTable = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IFood food = menu.FirstOrDefault(x => x.Name == foodName);
            string result = string.Empty;

            if (currentTable == null)
            {
                result = $"Could not find table with {tableNumber}";
            }
            else if (food == null || menu.Contains(food) == false)
            {
                result = $"No {foodName} in the menu";
            }
            else
            {
                foreach (var table in tables.Where(x => x.TableNumber == tableNumber))
                {
                    table.OrderFood(food);
                    result = $"Table {tableNumber} ordered {foodName}";
                }
            }

            return result;
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable currentTable = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
            IDrink drink = drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);
            string result = string.Empty;

            if (currentTable == null)
            {
                result = $"Could not find table with {tableNumber}";
            }
            else if (drink == null || drinks.Contains(drink) == false)
            {
                result = $"There is no {drinkName} {drinkBrand} available";
            }
            else
            {
                foreach (var table in tables.Where(x => x.TableNumber == tableNumber))
                {
                    table.OrderDrink(drink);
                    result = $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
                }
            }

            return result;
        }

        public string LeaveTable(int tableNumber)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var table in tables.Where(x => x.TableNumber == tableNumber))
            {
                decimal result = table.GetBill();
                totalIncome += result;
                table.Clear();

                sb.AppendLine($"Table: {tableNumber}");

                sb.Append($"Bill: {result:f2}");
            }

            return sb.ToString();
        }

        public string GetFreeTablesInfo()
        {
            string result = string.Empty;

            foreach (var table in tables.Where(x => x.NumberOfPeople == 0 && x.IsReserved == false))
            {
                result += table.GetFreeTableInfo();
            }

            return result.Trim();
        }

        public string GetOccupiedTablesInfo()
        {
            string result = string.Empty;

            foreach (var table in tables.Where(x => x.NumberOfPeople > 0 || x.IsReserved == true))
            {
                result += table.GetOccupiedTableInfo();
            }

            return result.Trim();
        }

        public string GetSummary()
        {
            return $"Total income: {totalIncome:f2}lv";
        }
    }
}
