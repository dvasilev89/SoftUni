using System;


class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string type = Console.ReadLine().ToLower();
        string delivery = Console.ReadLine().ToLower();

        double price = 0;

        if (num <= 10)
        {
            Console.WriteLine("Invalid order");
        }
        else
        {
            if (type == "90x130")
            {
                price = 110;
                price *= num;

                if (num > 60)
                {
                    price *= 0.92;
                }
                else if (num > 30)
                {
                    price *= 0.95;
                }
            }
            else if (type == "100x150")
            {
                price = 140;
                price *= num;

                if (num > 80)
                {
                    price *= 0.9;
                }
                else if (num > 40)
                {
                    price *= 0.94;
                }
            }
            else if (type == "130x180")
            {
                price = 190;
                price *= num;

                if (num > 50)
                {
                    price *= 0.88;
                }
                else if (num > 20)
                {
                    price *= 0.93;
                }
            }
            else if (type == "200x300")
            {
                price = 250;
                price *= num;

                if (num > 50)
                {
                    price *= 0.86;
                }
                else if (num > 25)
                {
                    price *= 0.91;
                }
            }

            if (delivery == "with delivery")
            {
                price += 60;
            }

            if (num >= 100)
            {
                price *= 0.96;
            }

            Console.WriteLine("{0:f2} BGN", price);
        }        
    }    
}