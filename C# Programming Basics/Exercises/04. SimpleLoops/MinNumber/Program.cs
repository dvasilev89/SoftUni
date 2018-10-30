using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = int.Parse(Console.ReadLine());

        int min = firstNumber;


        for (int i = 0; i < n - 1; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (min > num)
            {
                min = num;
            }
        }
        Console.WriteLine(min);
    }
}

