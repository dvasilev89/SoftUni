using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Foods.Contracts;
using SoftUniRestaurant.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniRestaurant.Models.Tables
{
    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
            this.FoodOrders = new List<IFood>();
            this.DrinkOrders = new List<IDrink>();            
        }

        public List<IFood> FoodOrders { get; private set; }
        public List<IDrink> DrinkOrders { get; private set; }
        public int TableNumber { get; set; }

        public int Capacity 
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }

                capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }

                numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; set; }
        public bool IsReserved { get; set; }

        public decimal Price => numberOfPeople * PricePerPerson;

        public void Reserve(int numberOfPeople)
        {
            IsReserved = true;
            this.NumberOfPeople = numberOfPeople;
        }

        public void OrderFood(IFood food)
        {
            FoodOrders.Add(food);
        }

        public void OrderDrink(IDrink drink)
        {
            DrinkOrders.Add(drink);
        }

        public decimal GetBill()
        {
            return FoodOrders.Sum(x => x.Price) + DrinkOrders.Sum(x => x.Price) + Price;
        }

        public void Clear()
        {
            FoodOrders.Clear();
            DrinkOrders.Clear();
            IsReserved = false;
            numberOfPeople = 0;
        }

        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");

            sb.AppendLine($"Type: {this.GetType().Name.ToString()}");

            sb.AppendLine($"Capacity: {this.capacity}");

            sb.AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString();
        }

        public string GetOccupiedTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");

            sb.AppendLine($"Type: {this.GetType().Name.ToString()}");

            sb.AppendLine($"Number of people: {this.numberOfPeople}");

            if (FoodOrders.Count == 0)
            {
                sb.Append("Food orders: None");
            }
            else
            {
                sb.AppendLine($"Food orders: {FoodOrders.Count}");

                foreach (var food in FoodOrders)
                {
                    sb.AppendLine($"{food.Name.ToString()}: {food.ServingSize}g - {food.Price:f2}");
                }
            }

            if (DrinkOrders.Count == 0)
            {
                sb.AppendLine("Drink orders: None");
            }
            else
            {
                sb.AppendLine($"Drink orders: {DrinkOrders.Count}");

                foreach (var drink in DrinkOrders)
                {
                    sb.Append($"{drink.Name.ToString()} {drink.Brand.ToString()} - {drink.ServingSize}ml - {drink.Price:f2}lv");
                }
            }

            return sb.ToString();
        }        
    }
}
