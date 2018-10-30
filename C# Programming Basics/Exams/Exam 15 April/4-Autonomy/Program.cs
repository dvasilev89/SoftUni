using System;



class Program
{
    static void Main(string[] args)
    {
        int width  = int.Parse(Console.ReadLine());
        int lenght = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int room = width * lenght * height;
        int boxesTotal = 0;
        string input = "";




        while ( boxesTotal < room )
        {
            input = Console.ReadLine().ToLower();

            if (input == "done")
            {
                break;
            }
            else
            {
                boxesTotal += int.Parse(input);
            }
        }

        if (boxesTotal < room)
        {
            Console.WriteLine("{0} Cubic meters left.", room- boxesTotal);
        }
        else
        {
            Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(room - boxesTotal));
        }


    }
}