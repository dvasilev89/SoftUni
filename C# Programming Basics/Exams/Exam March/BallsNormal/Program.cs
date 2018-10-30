using System;



class Program
{
    static void Main(string[] args)
    {
        int balls = int.Parse(Console.ReadLine());
        int TotalsPoints = 0;
        int PointsFromRed = 0;
        int PointsFromOrange = 0;
        int PointsFromYellow = 0;
        int PointsFromWhite = 0;
        int PointsFromBlack = 0;
        int CountOfOThers = 0;




        for (int i = 1; i <= balls; i++)
        {
            string colours = Console.ReadLine();
            //points = Mitio(colours, points);

            if (colours == "red")
            {
                 TotalsPoints += 5;
                PointsFromRed ++;
            }
            else if (colours == "orange")
            {
                 TotalsPoints += 10;
                PointsFromOrange++;

            }
            else if (colours == "yellow")
            {
                 TotalsPoints += 15;
                PointsFromYellow++;

            }
            else if (colours == "white")
            {
                 TotalsPoints += 20;
                PointsFromWhite++;

            }
            else if (colours == "black")
            {
                TotalsPoints = TotalsPoints / 2;
                PointsFromBlack++;
            }
            else
            {
                CountOfOThers++;

            }
        }
        Console.WriteLine("Total points: {0}", TotalsPoints);
        Console.WriteLine("Points from red balls: {0}", PointsFromRed);
        Console.WriteLine("Points from orange balls: {0}", PointsFromOrange);
        Console.WriteLine("Points from yellow balls: {0}", PointsFromYellow);
        Console.WriteLine("Points from white balls: {0}", PointsFromWhite);        
        Console.WriteLine("Other colors picked: {0}", CountOfOThers);
        Console.WriteLine("Divides from black balls: {0}", PointsFromBlack);

    }
    //static int Mitio(string str, int TotalsPoints)
    //{
    //    if (str == "red")
    //        return TotalsPoints + 5;
    //    else if (str == "orange")
    //        return TotalsPoints + 10;
    //    else if (str == "yellow")
    //        return TotalsPoints + 15;
    //    else if (str == "white")
    //        return TotalsPoints + 20;
    //    else if (str == "black")
    //        return TotalsPoints / 2;
    //    else
    //        return TotalsPoints;
    //}
}

