using System;


class Program
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        sbyte age = sbyte.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
    }
}

