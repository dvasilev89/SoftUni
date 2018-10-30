using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        int homes = int.Parse(Console.ReadLine());
        int initialPresents = int.Parse(Console.ReadLine());
        BigInteger totalPresents = initialPresents;

        BigInteger additionalPresents = 0;
        int visitedHomes = 0;
        int remainingHomes = 0;
        int timesBack = 0;

        for (int i = 1; i <= homes; i++)
        {
            visitedHomes = i;
            remainingHomes = homes - i;

            int presentsPerHouse = int.Parse(Console.ReadLine());

            if (totalPresents >= presentsPerHouse)
            {
                totalPresents -= presentsPerHouse;
            }
            else
            {
                while (totalPresents < presentsPerHouse)
                {
                    additionalPresents += (initialPresents / visitedHomes) * remainingHomes + -(totalPresents - presentsPerHouse);
                    totalPresents += additionalPresents;
                    timesBack++;
                }
                totalPresents -= presentsPerHouse;
            }

        }

        if (timesBack > 0)
        {
            Console.WriteLine(timesBack);
            Console.WriteLine(additionalPresents);
        }
        else
        {
            Console.WriteLine(totalPresents);
        }
    }
}
