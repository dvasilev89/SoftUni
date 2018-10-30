using System;



class Program
{
    static void Main(string[] args)
    {
        int balls = int.Parse(Console.ReadLine());
        int points = 0;

        for (int i = 1; i <= balls; i++)
        {
            string colours = Console.ReadLine();
            points = Mitio(colours,points);
        }
        Console.WriteLine();
    }
    static int Mitio(string str,int TotalsPoints)
    {
        if (str == "red")
            return TotalsPoints + 5;
        else if (str == "orange")
            return TotalsPoints + 10;
        else if (str == "yellow")
            return TotalsPoints + 15;
        else if (str == "white")
            return TotalsPoints + 20;
        else if (str == "black")
            return TotalsPoints / 2;
        else
            return TotalsPoints;
    }
}

