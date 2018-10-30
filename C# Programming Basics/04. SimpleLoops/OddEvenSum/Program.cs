using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int evenSum = 0, oddSum = 0;
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += element;
            }
            else
            {
                oddSum += element;
            }
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum = {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff = " + Math.Abs(oddSum - evenSum));
        }
    }
}

