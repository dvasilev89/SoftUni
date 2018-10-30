using System;



class Program
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        string package = Console.ReadLine().ToLower();

        double price = 0.0;
        string hall = "";

        if (people <= 50)
        {
            hall = "Small Hall";
            price += 2500;

            if (package == "normal")
            {
                
                price += 500;
                price = price - (price * 0.05);
                price = price / people;                
            }
            else if (package == "gold")
            {
                price += 750;
                price = price - (price * 0.1);
                price = price / people;
            }
            else if (package == "platinum")
            {                
                price += 1000;
                price = price - (price * 0.15);
                price = price / people;
            }

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", price);
        }
        else if (people > 50 && people <= 100)
        {
            hall = "Terrace";
            price += 5000;

            if (package == "normal")
            {

                price += 500;
                price = price - (price * 0.05);
                price = price / people;
            }
            else if (package == "gold")
            {
                price += 750;
                price = price - (price * 0.1);
                price = price / people;
            }
            else if (package == "platinum")
            {
                price += 1000;
                price = price - (price * 0.15);
                price = price / people;
            }

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", price);
        }
        else if (people > 100 && people <= 120)
        {
            hall = "Great Hall";
            price += 7500;

            if (package == "normal")
            {

                price += 500;
                price = price - (price * 0.05);
                price = price / people;
            }
            else if (package == "gold")
            {
                price += 750;
                price = price - (price * 0.1);
                price = price / people;
            }
            else if (package == "platinum")
            {
                price += 1000;
                price = price - (price * 0.15);
                price = price / people;
            }

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", price);
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}

