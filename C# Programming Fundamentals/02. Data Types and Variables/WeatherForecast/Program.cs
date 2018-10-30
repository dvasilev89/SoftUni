using System;


class Program
{
    static void Main(string[] args)
    {  
        string input = Console.ReadLine();

        bool isSbyte = sbyte.TryParse(input, out sbyte sbyteResult);
        bool isInt = int.TryParse(input, out int intResult);
        bool isLong = long.TryParse(input, out long longResult);
        bool isFloat = float.TryParse(input, out float floatResult);

        if (isSbyte)
        {
            Console.WriteLine("Sunny");
        }
        else if (isInt)
        {
            Console.WriteLine("Cloudy");
        }
        else if (isLong)
        {
            Console.WriteLine("Windy");
        }
        else if (isFloat)
        {
            Console.WriteLine("Rainy");
        }
    }
}

