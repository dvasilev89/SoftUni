using System;


class Program
{
    static void Main(string[] args)
    {
        byte key = byte.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        char result = '\0';
        string message = "";

        for (int i = 1; i <= n; i++)
        {
            int input = char.Parse(Console.ReadLine());
            result = (char) (input + key);
            message += result;
        }

        Console.WriteLine(message);
    }
}



