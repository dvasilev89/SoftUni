using System;
using System.Linq;

namespace Applied_rithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> AddOne = nums => nums.Select(number => number + 1).ToArray();
            Func<int[], int[]> SubtractOne = nums => nums.Select(number => number - 1).ToArray();
            Func<int[], int[]> Multiply = nums => nums.Select(number => number * 2).ToArray();

            Action<int[]> Print = nums => Console.WriteLine(string.Join(' ', nums));

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "add")
                {
                    numbers = AddOne(numbers);
                }
                else if (input == "subtract")
                {
                    numbers = SubtractOne(numbers);
                }
                else if (input == "multiply")
                {
                    numbers = Multiply(numbers);
                }
                else if (input == "print")
                {
                    Print(numbers);
                }

                input = Console.ReadLine();
            }
        }
    }
}
