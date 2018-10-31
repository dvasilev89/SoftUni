using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2_x_2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (inputNums.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                int rows = inputNums[0];
                int columns = inputNums[1];

                var matrix = new char[rows][];
                for (int row = 0; row < rows; row++)
                {
                    matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                }
                int counter = 0;
                for (int row = 0; row < rows - 1; row++)
                {
                    for (int col = 0; col < columns - 1; col++)
                        if (matrix[row][col] == matrix[row][col + 1] && matrix[row + 1][col] == matrix[row + 1][col + 1])
                            counter++;
                }
                Console.WriteLine(counter);
            }
        }
    }
}