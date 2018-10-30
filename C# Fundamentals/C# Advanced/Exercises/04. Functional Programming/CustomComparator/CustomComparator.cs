using System;
using System.Linq;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            Action<int[]> Print = nums => Console.WriteLine(string.Join(' ', nums));
            Func<int, int, int> sortFunc = (a, b) =>
                                           (a % 2 == 0 && b % 2 != 0) ? -1 :
                                           (a % 2 != 0 && b % 2 == 0) ? 1 :
                                           a.CompareTo(b);

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)                
                .ToArray();


            Array.Sort(numbers, new Comparison<int>(sortFunc));

            Print(numbers);
        }
    }
}
