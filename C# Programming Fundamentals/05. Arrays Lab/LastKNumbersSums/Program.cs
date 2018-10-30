using System;


class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());        

        long[] nSeq = new long[n];
        nSeq[0] = 1;

        for (int i = 1; i < n; i++)
        {

            for (int j = 1; j <= Math.Min(k, i); j++)
            {
                nSeq[i] += nSeq[i - j];
            }            
        }

        Console.WriteLine(string.Join(" ", nSeq));
    }
}

