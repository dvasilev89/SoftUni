using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCol = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rows = rowsAndCol[0];
            int col = rowsAndCol[1];

            int[,] matrix = new int[rows, col];     
            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = colElements[j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(col);

            int sum = 0;

            foreach (int number in matrix)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
