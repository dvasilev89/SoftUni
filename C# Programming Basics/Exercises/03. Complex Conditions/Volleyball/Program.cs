using System;



class Program
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int sofiaWeekends = 48 - h;
        double weekendGamesPlayed = sofiaWeekends * (3.0 / 4);
        int homeTownGamesPlayes = h;
        double gamesPlayedHolydays = p * (2.0 / 3);
        double allGames = weekendGamesPlayed + homeTownGamesPlayes + gamesPlayedHolydays;

        if (year == "normal")
        {
            double result = Math.Truncate(allGames);
            Console.WriteLine(result);
        }
        else if (year == "leap")
        {
            double result = Math.Truncate(allGames + (allGames * 0.15));
            Console.WriteLine(result);
        }
    }
}

