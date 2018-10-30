using System;


class Program
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        string primeNumbers = "";        

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i) && i >= 2)
            {
                primeNumbers += i + ", ";
            }           
        }

        primeNumbers = primeNumbers.Remove(primeNumbers.Length - 2);

        Console.WriteLine(primeNumbers);

    }

    static bool IsPrime(int n)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }     

        return isPrime;
    }
}

