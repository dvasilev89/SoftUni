﻿using System;


class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());
        int sum = 0;        

        for (int i = 1; i <= n; i++)
        {
            int word = char.Parse(Console.ReadLine());
            sum += word;
        }
        Console.WriteLine($"The sum equals: {sum}");        
    }
}

