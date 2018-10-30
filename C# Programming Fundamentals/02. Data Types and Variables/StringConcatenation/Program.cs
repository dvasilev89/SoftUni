using System;


class Program
{
    static void Main(string[] args)
    {
        char delimiter = char.Parse(Console.ReadLine());
        string evenOrOdd = Console.ReadLine();
        byte n = byte.Parse(Console.ReadLine());
        string even = "";
        string odd = "";

        for (int i = 1; i <= n; i++)
        {
           string input = Console.ReadLine();
            
            if (i % 2 == 0)
            {
                even += input + delimiter;
            }
            else
            {
                odd += input + delimiter;
            }
        }
        if (evenOrOdd == "even")
        {
            Console.WriteLine(even.Remove(even.Length - 1));
        }
        else
        {
            Console.WriteLine(odd.Remove(odd.Length - 1));
        }  
    }
}

