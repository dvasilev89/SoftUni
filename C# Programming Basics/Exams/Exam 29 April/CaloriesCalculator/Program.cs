using System;



class Program
{
    static void Main(string[] args)
    {        
        string gender = Console.ReadLine();
        double weight = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());
        string activity = Console.ReadLine();

        double BHM = 0.0;

        if (gender == "m")
        {
            BHM = 66 + (13.7 * weight) + (5 * (hight * 100)) - (6.8 * age);
        }
        else
        {
            BHM = 655 + (9.6 * weight) + (1.8 * (hight * 100)) - (4.7 * age);
        }

        if (activity == "sedentary")
        {
            BHM *= 1.2;
        }
        else if (activity == "lightly active")
        {
            BHM *= 1.375;
        }
        else if (activity == "moderately active")
        {
            BHM *= 1.55;
        }
        else if (activity == "very active")
        {
            BHM *= 1.725;
        }

        double result = Math.Ceiling(BHM);

        Console.WriteLine("To maintain your current weight you will need {0} calories per day.", result);




    }
}

