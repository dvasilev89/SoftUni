using System;


class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = GetMax(first, second);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char max = GetMax(first, second);
            Console.WriteLine(max);
        }
        else if (type == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string max = GetMax(first, second);
            Console.WriteLine(max);
        }

    }

    static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }

    static char GetMax(char first, char second)
    {
        char result = '\0';

        if (first > second)
        {
            result = first;
        }
        else
        {
            result = second;
        }

        return result;
    }

    static string GetMax(string first, string second)
    {
        string result = "";

        if (first.CompareTo(second) >= 0)
        {
            result = first;
        }
        else
        {
            result = second;
        }

        return result;
    }
}

