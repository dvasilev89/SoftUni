using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();

            int numberOfIntegers = int.Parse(Console.ReadLine());

            int evenInt = 0;

            for (int i = 0; i < numberOfIntegers; i++)
            {
                int integer = int.Parse(Console.ReadLine());

                if (numbers.Contains(integer))
                {
                    evenInt = integer;
                    numbers.Remove(integer);
                }
                else
                {
                    numbers.Add(integer);
                }
            }

            Console.WriteLine(evenInt);
        }
    }
}
