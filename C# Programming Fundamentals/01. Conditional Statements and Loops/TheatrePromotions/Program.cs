using System;


class Program
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());        

        if (0 <= age && age <= 18)
        {
            switch (day)
            {
                case "weekday": Console.WriteLine("12$"); break;
                case "weekend": Console.WriteLine("15$"); break;
                case "holiday": Console.WriteLine("5$"); break;
            }
        }
        else if (18 < age && age <= 64)
        {
            switch (day)
            {
                case "weekday": Console.WriteLine("18$"); break;
                case "weekend": Console.WriteLine("20$"); break;
                case "holiday": Console.WriteLine("12$"); break;
            }
        }
        else if (64 < age && age <= 122)
        {
            switch (day)
            {
                case "weekday": Console.WriteLine("12$"); break;
                case "weekend": Console.WriteLine("15$"); break;
                case "holiday": Console.WriteLine("10$"); break;
            }
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }
}

