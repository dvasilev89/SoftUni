using System;



class Program
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int hours = h;
        int minutes = (m % 60) + 15;

        if (minutes > 59)
        {
            hours += 1;
            minutes -= 60;
        }

        if (hours > 23)
        {
            hours = 0;
        }

        if (minutes < 10)
        {
            Console.WriteLine(hours + ":0" + minutes);
        }
        else
        {
            Console.WriteLine("{0}:{1}", hours, minutes);
        }
    }
}