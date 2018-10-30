using System;
using System.Linq;

namespace TheHeiganDance
{
    class TheHeiganDance
    {
        static double demageToHeigan = double.Parse(Console.ReadLine());
        static int playerPoints = 18500;
        static double heiganPoints = 3000000.0;

        static string killSpell = "";
        static int playerLastRow = 0;
        static int playerLastCol = 0;

        static bool isHeiganDead = false;
        static bool isPlayerDead = false;
        static bool isPlayerHit = false;
        static bool isCloudActive = false;

        static void Main(string[] args)
        {
            char[][] board = new char[15][];

            FillBoard(board);

            Spells(board);

            Print(board);
        }

        private static void Spells(char[][] board)
        {
            int playerRow = 0;
            int playerCol = 0;            

            while (isPlayerDead == false && isHeiganDead == false)
            {
                if (isCloudActive)
                {
                    playerPoints -= 3500;
                    isCloudActive = false;
                }

                string[] spellInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string spell = spellInfo[0];
                int spellRow = int.Parse(spellInfo[1]);
                int spellCol = int.Parse(spellInfo[2]);

                for (int row = spellRow - 1; row <= spellRow + 1; row++)
                {
                    for (int col = spellCol - 1; col <= spellCol + 1; col++)
                    {
                        if (IsInside(board, row, col))
                        {
                            if (board[row][col] == 'P')
                            {
                                playerRow = row;
                                playerCol = col;
                                isPlayerHit = true;
                            }
                            else
                            {
                                board[row][col] = '*';
                            }
                        }
                    }
                }

                if (isPlayerHit)
                {
                    PlayerMove(board, playerRow, playerCol);
                }

                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == '*')
                        {
                            board[i][j] = '-';
                        }
                    }
                }


                if (spell == "Cloud")
                {
                    if (isPlayerHit)
                    {
                        playerPoints -= 3500;
                        isCloudActive = true;
                    }
                }
                else if (spell == "Eruption")
                {
                    if (isPlayerHit)
                    {
                        playerPoints -= 6000;
                    }
                }

                if (playerPoints < 0)
                {
                    killSpell = spell;
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    isPlayerDead = true;
                }

                heiganPoints -= demageToHeigan;

                if (heiganPoints < 0)
                {
                    playerLastRow = playerRow;
                    playerLastCol = playerCol;
                    isHeiganDead = true;                    
                }
            }
        }

        private static void PlayerMove(char[][] board, int row, int col)
        {
            if (IsInside(board, row - 1, col) && isPlayerHit)
            {
                if (board[row - 1][col] == '-')
                {
                    board[row][col] = '*';
                    board[row - 1][col] = 'P';
                    isPlayerHit = false;
                }
            }
            if (IsInside(board, row, col + 1) && isPlayerHit)
            {
                if (board[row][col + 1] == '-')
                {
                    board[row][col] = '*';
                    board[row][col + 1] = 'P';
                    isPlayerHit = false;
                }
            }
            if (IsInside(board, row + 1, col) && isPlayerHit)
            {
                if (board[row + 1][col] == '-')
                {
                    board[row][col] = '*';
                    board[row + 1][col] = 'P';
                    isPlayerHit = false;
                }
            }
            if (IsInside(board, row, col - 1) && isPlayerHit)
            {
                if (board[row][col - 1] == '-')
                {
                    board[row][col] = '*';
                    board[row][col - 1] = 'P';
                    isPlayerHit = false;
                }
            }
        }

        private static void FillBoard(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                board[row] = new char[15];

                for (int col = 0; col < board[row].Length; col++)
                {
                    board[row][col] = '-';
                }
            }

            board[7][7] = 'P';
        }

        private static void Print(char[][] board)
        {
            //for (int i = 0; i < board.Length; i++)
            //{
            //    for (int j = 0; j < board[i].Length; j++)
            //    {
            //        Console.Write(board[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            if (isPlayerDead)
            {
                Console.WriteLine($"Heigan: {heiganPoints:f2}");

                if (killSpell == "Cloud")
                {
                    Console.WriteLine("Player: Killed by Plague Cloud");
                }
                else
                {
                    Console.WriteLine($"Player: Killed by {killSpell}");
                }
            }
            else
            {
                Console.WriteLine("Heigan: Defeated!");
                Console.WriteLine($"Player: {playerPoints}");
            }

            Console.WriteLine($"Final position: {playerLastRow}, {playerLastCol}");
        }

        private static bool IsInside(char[][] board, int row, int col)
        {
            bool isInside = row >= 0 && row < board.Length && col >= 0 && col < board[row].Length;

            return isInside;
        }
    }
}
