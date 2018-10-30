using System;


class Program
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        int phones = int.Parse(Console.ReadLine());
        string brand = Console.ReadLine().ToLower();

        int discount = 0;
        double price = 0;
        
        if (brand == "gsm4e")
        {
            price = 20.50;            
            discount += 1;
        }
        else if (brand == "mobifon4e")
        {
            price = 50.75;            
            discount += 2;
        }
        else if (brand == "telefon4e")
        {
            price = 115;            
            discount += 3;
        }

        if (phones > 10 && phones <= 20)
        {
            discount += 2;
        }
        else if (phones >= 20 && phones <= 50)
        {
            discount += 5;
        }
        else if (phones > 50)
        {
            discount += 7;
        }

        double totalPrice = phones * price;
        double discountPrise = (totalPrice - (totalPrice * discount / 100));

        if (discountPrise < budget)
        {
            double money = budget - discountPrise;
            Console.WriteLine("The company bought all mobile phones. {0:f2} leva left.", money);
        }
        else if (discountPrise > budget)
        {
            double money = discountPrise - budget;
            Console.WriteLine("Not enough money for all mobiles. Company needs {0:f2} more leva.", money);
        }
    }
}

