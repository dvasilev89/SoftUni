using System;
using System.Linq;

namespace Problem1DangerousFloor
{
    class DangerousFloor
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];

            for (int i = 0; i < 8; i++)
            {
                char[] line = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = line[j];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                char[] command = input.ToCharArray();

                bool isPiece = true;
                bool isMoveValid = true;
                bool isOnBoard = true;

                char chessPiece = command[0];
                char rowPiece = command[1];
                char colPiece = command[2];
                char rowMove = command[4];
                char colMove = command[5];

                if (board[rowPiece, colPiece] != chessPiece)
                {
                    isPiece = false;
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }
                else if (isPiece)
                {
                    if (chessPiece == 'K' && (Math.Abs((rowPiece + colPiece) - (rowMove + colMove)) != 1))
                    {
                        isMoveValid = false;
                        Console.WriteLine("Invalid move!");
                        continue;
                    }
                    else if (chessPiece == 'K' && (Math.Abs((rowPiece + colPiece) - (rowMove + colMove)) != 1))

                }


            }


        }
    }
}
