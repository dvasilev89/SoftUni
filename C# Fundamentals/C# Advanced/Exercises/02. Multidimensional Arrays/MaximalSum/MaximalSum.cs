using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int i = 0; i < matrix.GetLength(0)- 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                     matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                                     matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startRow = i;
                        startCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[startRow + i, startCol + j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
