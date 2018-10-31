using System;

namespace Problem2KnightGame
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());

            char[,] table = new char[rowsCols, rowsCols];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                char[] line = Console.ReadLine().ToCharArray();

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = line[j];
                }
            }

            bool upLeft = false;
            bool upRight = false;
            bool downLeft = false;
            bool downRight = false;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 'K')
                    {
                        
                    }
                }
            }
        }
    }
}
