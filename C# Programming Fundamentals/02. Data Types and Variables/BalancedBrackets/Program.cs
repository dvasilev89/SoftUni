using System;


class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());
        int openBracket = 0;
        int closingBracket = 0;

        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();
            
            if (input == "(")
            {
                openBracket++;
            }
            else if (input == ")")
            {
                closingBracket++;
            }
        }

        if (openBracket == closingBracket)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}

