using System;



class Program
{
    static void Main(string[] args)
    {
        int passengers = int.Parse(Console.ReadLine());
        int busStops = int.Parse(Console.ReadLine());

        int allPassengers = passengers;

        for (int rows = 1; rows <= busStops; rows++)
        {
            int exit = int.Parse(Console.ReadLine());
            int enter = int.Parse(Console.ReadLine());

            if (rows % 2 == 1)
            {
                allPassengers = allPassengers - exit;
                allPassengers = allPassengers + enter + 2;
            }
            else
            {
                allPassengers = allPassengers - exit - 2;
                allPassengers = allPassengers + enter;
            }           
        }
        Console.WriteLine("The final number of passengers is : {0}", allPassengers);
    }
}