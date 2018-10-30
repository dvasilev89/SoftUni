using System;


class Program
{   
    static void Main(string[] args)
    {
        char symbol = char.Parse(Console.ReadLine());
        PrintReceip(symbol);
    }

    static void PrintReceip(char symbol)
    {
        PrintReceipHeader(symbol, 30);
        PrintReceipBody('_', 20);
        PrintReceipFooter('-', 30);
    }

    static void PrintReceipHeader(char symbol, int count)
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine(new string(symbol, count));        
    }

    static void PrintReceipBody(char symbol, int count)
    {
        Console.WriteLine("Charged to" + new string(symbol, count));
        Console.WriteLine("Received by" + new string(symbol, count - 1));        
    }

    static void PrintReceipFooter(char symbol, int count)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine(new string(symbol, count));
        Console.WriteLine('\u00A9' + " SoftUni");        
    }
}
