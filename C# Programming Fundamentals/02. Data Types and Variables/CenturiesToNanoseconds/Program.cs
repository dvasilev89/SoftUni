using System;


class Program
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        decimal minutes = hours * 60;
        decimal seconds = minutes * 60;
        decimal milliseconds = seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;


        Console.Write($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($" = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}

