using System;
using System.Linq;

namespace SquareMaximumSum
{
    class SquareMaximumSum
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .ToArray();



            char[,] matrix = new char[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowElements = Console.ReadLine()
                    .Split(", ")
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    bool areEqual = matrix[row, col] == matrix[row, col + 1] &&
                                    matrix[row, col] == matrix[row + 1, col + 1] &&
                                    matrix[row, col] == matrix[row + 1, col];

                    if (areEqual)
                    {
                        counter++;                        
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
