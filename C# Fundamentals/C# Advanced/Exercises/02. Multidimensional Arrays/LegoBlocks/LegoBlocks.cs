using System;
using System.Linq;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstArray = new int[rows][];
            int[][] secondArray = new int[rows][];
            int[][] thirdArray = new int[rows][];

            GetInput(firstArray, secondArray, rows);

            CombineArrays(firstArray, secondArray, thirdArray);

            bool isRectangular = IsRectangular(thirdArray);            

            Print(thirdArray, isRectangular);
        }

        private static bool IsRectangular(int[][] thirdArray)
        {
            bool isRectangular = true;

            int colSize = thirdArray[0].Length;

            for (int row = 1; row < thirdArray.Length; row++)
            {
                if (thirdArray[row].Length != colSize)
                {
                    isRectangular = false;
                }
            }

            return isRectangular;
        }

        private static void CombineArrays(int[][] firstArray, int[][] secondArray, int[][] thirdArray)
        {
            for (int row = 0; row < thirdArray.Length; row++)
            {
                thirdArray[row] = new int[firstArray[row].Length + secondArray[row].Length];

                int count = 0;

                for (int col = 0; col < (firstArray[row].Length + secondArray[row].Length); col++)
                {
                    if (col >= firstArray[row].Length)
                    {
                        thirdArray[row][col] = secondArray[row][count++];
                    }
                    else
                    {
                        thirdArray[row][col] = firstArray[row][col];
                    }

                }
            }
        }

        private static void Print(int[][] thirdArray, bool isRectangular)
        {
            if (isRectangular)
            {
                foreach (var row in thirdArray)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            else
            {
                int counter = 0;

                foreach (var row in thirdArray)
                {
                    counter += row.Length;
                }
                Console.WriteLine($"The total number of cells is: {counter}");
            }
        }

        private static void GetInput(int[][] firstArray, int[][] secondArray, int rows)
        {
            for (int row = 0; row < firstArray.Length; row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                firstArray[row] = input;
            }

            for (int row = 0; row < secondArray.Length; row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                input = input.Reverse().ToArray();

                secondArray[row] = input;
            }
        }
    }
}
