using System;
using System.Linq;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

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

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                firstDiagonalSum += matrix[i, i];
                secondDiagonalSum += matrix[i, (matrix.GetLength(0) - 1 - i)];
            }

            int result = Math.Abs(firstDiagonalSum - secondDiagonalSum);

            Console.WriteLine(result);
        }
    }
}
