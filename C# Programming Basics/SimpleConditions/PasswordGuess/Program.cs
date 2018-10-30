using System;


class Program
{
    static void Main(string[] args)
    {
        string pass = "s3cr3t!P@ssw0rd";
        string userInput = Console.ReadLine();

        if (userInput == pass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}

