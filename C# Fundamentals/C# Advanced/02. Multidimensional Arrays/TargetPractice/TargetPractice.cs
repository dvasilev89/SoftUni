using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            char[,] pattern = new char[rows, cols];

            char[] snake = Console.ReadLine().ToCharArray();

            int counter = 0;
            bool isLeft = true;

            for (int row = pattern.GetLength(0) - 1; row >= 0; row--)
            {
                if (isLeft)
                {
                    for (int col = pattern.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }

                        pattern[row, col] = snake[counter];
                        counter++;

                    }

                    isLeft = false;
                }
                else
                {
                    for (int col = 0; col < pattern.GetLength(1); col++)
                    {
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }

                        pattern[row, col] = snake[counter];
                        counter++;

                    }

                    isLeft = true;
                }
            }

            int[] shotParameters = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int impactRow = shotParameters[0];
            int impactCol = shotParameters[1];
            int radius = shotParameters[2];

            for (int row = 0; row < pattern.GetLength(0); row++)
            {
                for (int col = 0; col < pattern.GetLength(1); col++)
                {
                    bool isInside = Math.Pow(impactRow - row, 2) + Math.Pow(impactCol - col, 2) <= Math.Pow(radius, 2);

                    if (isInside)
                    {
                        pattern[row, col] = ' ';
                    }
                }
            }

            Queue<char> elements = new Queue<char>(pattern.GetLength(0));

            for (int col = 0; col < pattern.GetLength(1); col++)
            {
                int secondCounter = 0;

                for (int row = 0; row < pattern.GetLength(0); row++)
                {
                    if (pattern[row, col] != ' ')
                    {
                        elements.Enqueue(pattern[row, col]);
                    }
                    else
                    {
                        secondCounter++;
                    }
                }

                for (int row = 0; row < secondCounter; row++)
                {
                    pattern[row, col] = ' ';
                }

                for (int row = secondCounter; row < pattern.GetLength(0); row++)
                {
                    pattern[row, col] = elements.Dequeue();
                }
            }

            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    Console.Write(pattern[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
