using System;


class Program
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double hight = double.Parse(Console.ReadLine());
        double averageHight = double.Parse(Console.ReadLine());

        double spaceshipCubicArea = width * lenght * hight;
        double roomCubicArea = (averageHight + 0.4) * 4;

        double total = Math.Floor(spaceshipCubicArea / roomCubicArea);

        if (total < 3)
        {
            Console.WriteLine("The spacecraft is too small.");
        }
        else if (total >= 3 && total <= 10)
        {
            Console.WriteLine("The spacecraft holds {0} astronauts." ,total);
        }
        else if (total > 10)
        {
            Console.WriteLine("The spacecraft is too big.");
        }
    }
}

