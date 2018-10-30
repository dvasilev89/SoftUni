using System;


class Program
{
    static void Main(string[] args)
    {
        string idType = Console.ReadLine();
        byte n = byte.Parse(Console.ReadLine());
        long max = 0;
        long result = long.MinValue;

        switch (idType)
        {
            case "sbyte": max = sbyte.MaxValue; break;
            case "int": max = int.MaxValue; break;
            case "long": max = long.MaxValue; break;
        }

        for (int i = 1; i <= n; i++)
        {
            long id = long.Parse(Console.ReadLine());

            if (id <= max)
            {
                id = Math.Max(result, id);
                result = id;                
            }
        }
        Console.WriteLine(result);
    }
}

