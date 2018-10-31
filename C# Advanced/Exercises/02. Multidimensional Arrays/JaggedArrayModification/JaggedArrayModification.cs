using System;
using System.Linq;

namespace JaggedArrayModification
{
    class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[row] = new int[rowElements.Length];

                for (int col = 0; col < rowElements.Length; col++)
                {
                    jagged[row][col] = rowElements[col];
                }
            }

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "END")
                {
                    break;
                }

                string[] command = commands
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string addOrSubtract = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }                

                if (addOrSubtract == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (addOrSubtract == "Subtract")
                {
                    jagged[row][col] -= value;
                }
            }

            foreach (int[] column in jagged)
            {
                Console.WriteLine(string.Join(" ", column));
            }
        }
    }
}
