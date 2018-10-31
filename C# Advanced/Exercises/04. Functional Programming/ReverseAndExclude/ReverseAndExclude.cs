using System;
using System.Linq;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> ReverseNum = nums => nums.Reverse().ToArray();
            Action<int[]> Print = nums =>
            Console.WriteLine(string.Join(' ', nums));


            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divNumber = int.Parse(Console.ReadLine());

            numbers = ReverseNum(numbers).Where(x => x % divNumber != 0).ToArray();

            Print(numbers);            
        }        
    }
}
