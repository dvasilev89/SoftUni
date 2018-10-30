using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int money = int.Parse(Console.ReadLine());

        string weapon = "";
        int price = 0;

        if (n > 7)
        {
            Console.WriteLine("Sorry, you can't carry so many things!");
            return;
        }
        
        for (int i =1; i <= n; i++)
        {
            weapon = Console.ReadLine();
            
            switch (weapon)
            {
                case "ak47": price += 2700; break;
                case "awp": price += 4750; break;
                case "sg553": price += 3500; break;
                case "grenade": price += 300; break;
                case "flash": price += 250; break;
                case "glock": price += 500; break;
                case "bazooka": price += 5600; break;
            }
            
        }
        if (price > money)
        {
            Console.WriteLine("Not enough money! You need {0} more money.", price - money);
        }
        else
        {
            Console.WriteLine("You bought all {0} items! Get to work and defeat the bomb!", n);
        }
    }
}

