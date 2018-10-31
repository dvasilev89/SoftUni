using System;
using System.Linq;

namespace Exam3Miner
{
    class Miner
    {
        static int rowsCols = int.Parse(Console.ReadLine());

        static char[][] field = new char[rowsCols][];

        static string[] comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


        static int sRow = 0;
        static int sCol = 0;
        static int totalCoals = 0;
        static int coalsCollected = 0;

        static bool isGameOver = false;
        static bool isAllCoalsCollected = false;

        static void Main(string[] args)
        {

            GetField();

            PlayerMove();            

            Print();

        }

        private static void PlayerMove()
        {
            for (int i = 0; i < comands.Length; i++)
            {
                string comand = comands[i];

                if (comand == "left")
                {
                    if (IsInside(sRow, sCol - 1))
                    {
                        if (field[sRow][sCol - 1] == 'c')
                        {                            
                            field[sRow][sCol - 1] = 's';
                            coalsCollected++;
                            sCol--;
                        }
                        else if (field[sRow][sCol - 1] == 'e')
                        {
                            isGameOver = true;
                            sCol--;
                            break;
                        }
                        else
                        {
                            field[sRow][sCol - 1] = 's';
                            sCol--;
                        }
                    }
                }
                else if (comand == "right")
                {
                    if (IsInside(sRow, sCol + 1))
                    {
                        if (field[sRow][sCol + 1] == 'c')
                        {
                            field[sRow][sCol + 1] = 's';
                            coalsCollected++;
                            sCol++;
                        }
                        else if (field[sRow][sCol + 1] == 'e')
                        {
                            isGameOver = true;
                            sCol++;
                            break;
                        }
                        else
                        {
                            field[sRow][sCol + 1] = 's';
                            sCol++;
                        }
                    }
                }
                else if (comand == "up")
                {
                    if (IsInside(sRow - 1, sCol))
                    {
                        if (field[sRow - 1][sCol] == 'c')
                        {
                            field[sRow - 1][sCol] = '*';
                            coalsCollected++;
                            sRow--;
                        }
                        else if (field[sRow - 1][sCol] == 'e')
                        {
                            isGameOver = true;
                            sRow--;
                            break;
                        }
                        else
                        {
                            field[sRow - 1][sCol] = 's';
                            sRow--;
                        }
                    }
                }
                else if (comand == "down")
                {
                    if (IsInside(sRow + 1, sCol))
                    {
                        if (field[sRow + 1][sCol] == 'c')
                        {
                            field[sRow + 1][sCol] = '*';
                            coalsCollected++;
                            sRow++;
                        }
                        else if (field[sRow + 1][sCol] == 'e')
                        {
                            isGameOver = true;
                            sRow++;
                            break;
                        }
                        else
                        {
                            field[sRow + 1][sCol] = 's';
                            sRow++;
                        }
                    }
                }

                if (totalCoals == coalsCollected)
                {
                    isAllCoalsCollected = true;
                    break;
                }                
            }
        }

        private static bool IsInside(int row, int col)
        {
            bool isInside = row >= 0 && row < field.Length && col >= 0 && col < field[row].Length;

            return isInside;
        }

        private static void Print()
        {      

            if (isGameOver == true)
            {
                Console.WriteLine($"Game over! ({sRow}, {sCol})");
            }
            else if (isAllCoalsCollected)
            {
                Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
            }
            else
            {
                Console.WriteLine($"{totalCoals - coalsCollected} coals left. ({sRow}, {sCol})");
            }
        }

        private static void GetField()
        {
            for (int row = 0; row < field.Length; row++)
            {
                field[row] = new char[rowsCols];

                char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = line[col];

                    if (line[col] == 's')
                    {
                        sRow = row;
                        sCol = col;
                    }

                    if (line[col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }
        }
    }
}
