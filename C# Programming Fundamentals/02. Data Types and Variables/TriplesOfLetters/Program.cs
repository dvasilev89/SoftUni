﻿using System;


class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());        

        for (char i = 'a'; i < 'a' + n; i++)            
        {
            for (char j = 'a'; j < 'a' + n; j++)
            {
                for (char k = 'a'; k <'a' + n; k++)
                {
                    Console.WriteLine("{0}{1}{2}", i , j , k);
                }               
            }                        
        }
    }
}

