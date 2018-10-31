using System;
using System.Linq;

namespace RadioactiveBunnies
{
    class RadioactiveBunnies
    {

        static int playerRow = 0;
        static int playerCol = 0;
        static bool isDead = false;
        static int deadRow = 0;
        static int deadCol = 0;

        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            char[,] lair = new char[rows, cols];

            GetInput(lair);

            char[] commands = Console.ReadLine().ToCharArray();

            PlayerMoves(lair, commands);

            Console.WriteLine();

            Print(lair);

            if (isDead)
            {
                Console.WriteLine($"dead: {deadRow} {deadCol}");
            }
            else
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }

        private static void PlayerMoves(char[,] lair, char[] commands)
        {

            bool isFound = false;

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'P')
                    {
                        isFound = true;
                        playerRow = row;
                        playerCol = col;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'U')
                {
                    if (playerRow > 0)
                    {

                        if (lair[playerRow - 1, playerCol] == 'B')
                        {
                            isDead = true;
                            lair[playerRow, playerCol] = '.';
                            deadRow = playerRow - 1;
                            deadCol = playerCol;
                            break;
                        }
                        else
                        {
                            lair[playerRow, playerCol] = '.';
                            lair[playerRow - 1, playerCol] = 'P';
                            playerRow--;
                        }
                    }
                }
                else if (commands[i] == 'D')
                {
                    if (playerRow < lair.GetLength(0))
                    {

                        if (lair[playerRow + 1, playerCol] == 'B')
                        {
                            isDead = true;
                            lair[playerRow, playerCol] = '.';
                            deadRow = playerRow + 1;
                            deadCol = playerCol;
                            break;

                        }
                        else
                        {
                            lair[playerRow, playerCol] = '.';
                            lair[playerRow + 1, playerCol] = 'P';
                            playerRow++;
                        }
                    }
                }
                else if (commands[i] == 'L')
                {
                    if (playerCol > 0)
                    {

                        if (lair[playerRow, playerCol - 1] == 'B')
                        {
                            isDead = true;
                            lair[playerRow, playerCol] = '.';
                            deadRow = playerRow;
                            deadCol = playerCol - 1;
                            break;
                        }
                        else
                        {
                            lair[playerRow, playerCol] = '.';
                            lair[playerRow, playerCol - 1] = 'P';
                            playerCol--;
                        }
                    }
                }
                else if (commands[i] == 'R')
                {
                    if (playerCol < lair.GetLength(1))
                    {

                        if (lair[playerRow, playerCol + 1] == 'B')
                        {
                            isDead = true;
                            lair[playerRow, playerCol] = '.';
                            deadRow = playerRow;
                            deadCol = playerCol + 1;
                            break;
                        }
                        else
                        {
                            lair[playerRow, playerCol] = '.';
                            lair[playerRow, playerCol + 1] = 'P';
                            playerCol++;
                        }
                    }
                }               

                for (int row = 0; row < lair.GetLength(0); row++)
                {                   

                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            if (row > 0)
                            {
                                lair[row - 1, col] = 'B';
                            }

                            if (row < lair.GetLength(0) - 1)
                            {
                                lair[row + 1, col] = 'B';
                            }

                            if (col > 0)
                            {
                                lair[row, col - 1] = 'B';
                            }

                            if (col < lair.GetLength(1) - 1)
                            {
                                lair[row, col + 1] = 'B';
                            }

                        }
                        if (isDead)
                        {
                            break;
                        }

                    }
                    if (isDead)
                    {
                        break;
                    }

                }
                                
            }
        }

        private static void Print(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void GetInput(char[,] lair)
        {
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    lair[row, col] = colElements[col];
                }
            }
        }
    }
}
