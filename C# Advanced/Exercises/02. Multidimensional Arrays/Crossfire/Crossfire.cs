using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    class Crossfire
    {
        static List<List<int>> matrix = new List<List<int>>();

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            GetMatrix(rows, cols);

            GetNukes();             

            Print();
        }

        private static bool IsNukeInside(int row, int col)
        {
            bool isInside = row >= 0 &&
                            row < matrix.Count &&
                            col >= 0 &&
                            col < matrix[row].Count;            
            return isInside;
        }

        private static void NukeMatrix(int nukeRow, int nukeCol, int nukeRadius)
        {
            for (int row = nukeRow - nukeRadius; row <= nukeRow + nukeRadius; row++)
            {
                if (IsNukeInside(row, nukeCol))
                {
                    matrix[row][nukeCol] = 0;
                }
            }

            for (int col = nukeCol - nukeRadius; col <= nukeCol + nukeRadius; col++)
            {
                if (IsNukeInside(nukeRow, col))
                {
                    matrix[nukeRow][col] = 0;
                }
            }

            for (int row = 0; row < matrix.Count; row++)
            {
                matrix[row].RemoveAll(x => x == 0);

                if (matrix[row].Count == 0)
                {
                    matrix.RemoveAt(row);
                    row--;
                }
            }
        }

        private static void GetNukes()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Nuke it from orbit")
                {
                    break;
                }

                int[] nukeArray = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int nukeRow = nukeArray[0];
                int nukeCol = nukeArray[1];
                int nukeRadius = nukeArray[2];

                NukeMatrix(nukeRow, nukeCol, nukeRadius);
            }
        }

        private static void Print()
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }           
        }

        private static void GetMatrix(int rows, int cols)
        {
            int counter = 1;

            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());

                for (int col = 0; col < cols; col++)
                {
                    matrix[row].Add(counter++);
                }
            }
        }
    }
}
