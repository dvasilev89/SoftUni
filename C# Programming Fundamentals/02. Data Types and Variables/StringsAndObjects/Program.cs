using System;


class Program
{
    static void Main(string[] args)
    {
        string first = "Hello";
        string second = "World";

        object firstSecond = (first + " " + second);

        string final = (string) (firstSecond);

        Console.WriteLine(final);
    }
}

