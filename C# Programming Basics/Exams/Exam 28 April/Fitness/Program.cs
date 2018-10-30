using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double forMen = 0.0;
            double forWomen = 0.0;
            double price = 0.0;

            if (sport == "Gym")
            {
                forMen = 42.0;
                forWomen = 35.0;
            }
            else if (sport == "Boxing")
            {
                forMen = 41.0;
                forWomen = 37.0;
            }
            else if (sport == "Yoga")
            {
                forMen = 45.0;
                forWomen = 42.0;
            }
            else if (sport == "Zumba")
            {
                forMen = 34.0;
                forWomen = 31.0;
            }
            else if (sport == "Dances")
            {
                forMen = 51.0;
                forWomen = 53.0;
            }
            else if (sport == "Pilates")
            {
                forMen = 39.0;
                forWomen = 37.0;
            }
            //-----
            if (sex == "m")
            {
                price = forMen;
            }
            else
            {
                price = forWomen;
            }
            //------
            if (age <= 19)
            {
                price *= 0.8;
            }

            if (money >= price)
            {
                Console.WriteLine("You purchased a 1 month pass for {0}.",sport);
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:f2} more.",price - money);
            }
        }
    }
}
