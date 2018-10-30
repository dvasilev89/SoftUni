using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int bigNum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            sum += num;
            
            if (num > bigNum)
            {
                bigNum = num;
            }
        }

        sum = sum - bigNum;

        if (sum == bigNum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sum);
        }
        else
        {
            double diff = Math.Abs(bigNum - sum);
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", diff);
        }
    }
}

