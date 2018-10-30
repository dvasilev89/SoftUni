using System;


class Program
{
    static void Main(string[] args)
    {
        string userInputOne = Console.ReadLine().ToLower();
        string userInputTwo = Console.ReadLine().ToLower();

        if (userInputOne == userInputTwo)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

