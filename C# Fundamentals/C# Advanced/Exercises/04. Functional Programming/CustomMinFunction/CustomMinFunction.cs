using System;
using System.Linq;

namespace CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNum = numbers => numbers.Min();

           int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)              
                .ToArray();

            Console.WriteLine(smallestNum(nums));
        }
    }
}
