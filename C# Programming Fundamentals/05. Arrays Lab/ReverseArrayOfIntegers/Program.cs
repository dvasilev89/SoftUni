using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int [n];

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            nums[i] = input;
        }

        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(nums[i]);
        }        
    }
}

