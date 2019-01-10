using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    string age = input[1];
                    string id = input[2];
                    string birthdate = input[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    string age = input[1];
                    string group = input[2];

                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                var buyer = buyers.SingleOrDefault(b => b.Name == name);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
