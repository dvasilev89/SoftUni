using System;



class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();

        double male = 0.0;
        double female = 0.0;

        if (gender == "m")
        {
            if (sport == "Gym")
            {
                male += 42;
            }
            else if (sport == "Boxing")
            {
                male += 41;
            }
            else if (sport == "Yoga")
            {
                male += 45;
            }
            else if (sport == "Zumba")
            {
                male += 34;
            }
            else if (sport == "Dances")
            {
                male += 51;
            }
            else if (sport == "Pilates")
            {
                male += 39;
            }
        }
        else
        {
            if (sport == "Gym")
            {
                female += 35;
            }
            else if (sport == "Boxing")
            {
                female += 37;
            }
            else if (sport == "Yoga")
            {
                female += 42;
            }
            else if (sport == "Zumba")
            {
                female += 31;
            }
            else if (sport == "Dances")
            {
                female += 53;
            }
            else if (sport == "Pilates")
            {
                female += 37;
            }
        }

        
        if (age <= 19)
        {
            male *= 0.8;
            female *= 0.8;
        }

        double result = male + female;

        if (money >= result)
        {
            Console.WriteLine("You purchased a 1 month pass for {0}.", sport);
        }
        else
        {
            Console.WriteLine("You don't have enough money! You need ${0:f2} more.", result - money);
        }


    }
}

