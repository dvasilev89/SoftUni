using System;


class Program
{
    static void Main(string[] args)
    {
        int oddBoat = char.Parse(Console.ReadLine());
        int evenBoat = char.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        int oddMoves = 0;
        int evenMoves = 0;

        for (int i = 1; i <= n; i++)
        {
            string input = Console.ReadLine();

            if (input == "UPGRADE")
            {
                oddBoat += 3;
                evenBoat += 3;
            }            
            else if (i % 2 != 0)
            {
                oddMoves += (input.Length);
            }
            else
            {
                evenMoves += (input.Length);
            }

            if (oddMoves >= 50 || evenMoves >= 50)
            {
                break;             
            }            
        }

        if (oddMoves > evenMoves)
        {
            Console.WriteLine((char) (oddBoat));
        }
        else
        {
            Console.WriteLine((char) (evenBoat));
        }
    }
}

