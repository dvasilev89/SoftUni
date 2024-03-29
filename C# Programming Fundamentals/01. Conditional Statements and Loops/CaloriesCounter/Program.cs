﻿using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int calories = 0;

        for (int i = 1; i <= n; i++)
        {
            string ingredients = Console.ReadLine().ToLower();

            switch (ingredients)
            {
                case "cheese": calories += 500; break;
                case "tomato sauce": calories += 150; break;
                case "salami": calories += 600; break;
                case "pepper": calories += 50; break;
            }
        }

        Console.WriteLine("Total calories: {0}", calories);
    }
}

