using System;


class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());        
        string letter = "";

        for (int i = 1; i <= n; i++)
        {
            string word =Console.ReadLine();
            letter += word;            
        }
        Console.WriteLine($"The word is: {letter}");        
    }
}

