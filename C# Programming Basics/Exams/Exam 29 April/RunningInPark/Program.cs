using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double time = 0.0;
        double totalDistance = 0.0;
        double calories = 0.0;        

        for (int i =1; i <= n; i++)
        {
            int runningMinutes = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            string units = Console.ReadLine();

            if (units == "m")
            {
                distance /= 1000;
            }

            totalDistance += distance;
            time += runningMinutes;
            calories += runningMinutes * 20;


        }

        Console.WriteLine("He ran {0:f2}km for {1} minutes and burned {2} calories.", totalDistance, time, calories) ;
        
    }
}

