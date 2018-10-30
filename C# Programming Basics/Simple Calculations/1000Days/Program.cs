using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string dateString = Console.ReadLine();
        string format = "dd-MM-yyyy";
        DateTime result;
        CultureInfo provider = CultureInfo.InstalledUICulture;

        result = DateTime.ParseExact(dateString, format, provider);
        result = result.AddDays(999);

        Console.WriteLine(result.ToString(format));
    }
}