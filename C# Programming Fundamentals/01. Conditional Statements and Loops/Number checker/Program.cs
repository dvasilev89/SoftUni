﻿using System;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");            
        }
    }
}

