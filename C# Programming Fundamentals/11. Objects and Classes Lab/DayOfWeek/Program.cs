using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}

