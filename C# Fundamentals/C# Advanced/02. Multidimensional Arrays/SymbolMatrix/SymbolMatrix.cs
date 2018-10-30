using System;

namespace SymbolMatrix
{
    class SymbolMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowElements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }

            char wantedChar = char.Parse(Console.ReadLine());

            bool wantedCharFound = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int currentChar = matrix[i, j];

                    if (currentChar == wantedChar)
                    {
                        wantedCharFound = true;
                        Console.WriteLine($"({i}, {j})");
                        break;
                    }
                }

                if (wantedCharFound == true)
                {
                    break;
                }
            }

            if (wantedCharFound == false)
            {
                Console.WriteLine($"{wantedChar} does not occur in the matrix");
            }
        }
    }
}
