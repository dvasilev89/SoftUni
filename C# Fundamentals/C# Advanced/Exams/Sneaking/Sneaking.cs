using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem2Sneaking
{
    class Sneaking
    {
        static void Main(string[] args)
        {

            int rows = int.Parse(Console.ReadLine());

            char[][] pattern = new char[rows][];

            int samRow = 0;
            int samCol = 0;
            bool samDead = false;
            bool nikoladzeDead = false;

            for (int i = 0; i < rows; i++)
            {
                string strInput = Console.ReadLine();

                if (Regex.IsMatch(strInput, "S"))
                {
                    samRow = i;
                    samCol = strInput.IndexOf('S');

                    if (Regex.IsMatch(strInput, "N"))
                    {
                        nikoladzeDead = true;
                    }
                }

                char[] input = strInput.ToCharArray();

                pattern[i] = input;
            }

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (char command in commands)
            {
                // Check if S is dead
                for (int i = 0; i < samCol; i++) // check for 'b'
                {
                    if (pattern[samRow][i] == 'b')
                    {
                        samDead = true;
                        break;
                    }
                    else if (pattern[samRow][i] == 'N')
                    {
                        nikoladzeDead = true;
                        break;
                    }
                }

                for (int i = samCol + 1; i < pattern[samRow].Length; i++) // check for 'd'
                {
                    if (pattern[samRow][i] == 'd')
                    {
                        samDead = true;
                        break;
                    }
                    else if (pattern[samRow][i] == 'N')
                    {
                        nikoladzeDead = true;
                        break;
                    }
                }

                if (samDead)
                {
                    break;
                }

                // Enemy movement
                for (int row = 0; row < pattern.Length; row++)
                {
                    // first cell

                    if (nikoladzeDead == false)
                    {
                        if (pattern[row][0] == 'd')
                        {
                            pattern[row][0] = 'b';
                        }
                        else if (pattern[row][0] == 'b')
                        {
                            pattern[row][0] = '.';
                            pattern[row][1] = 'b';
                        }
                        else if (pattern[row][(pattern[row].Length - 1)] == 'b') //last cell
                        {
                            pattern[row][(pattern[row].Length - 1)] = 'd';
                        }
                        else if (pattern[row][(pattern[row].Length - 1)] == 'd')
                        {
                            pattern[row][pattern[row].Length - 1] = '.';
                            pattern[row][pattern[row].Length - 2] = 'd';
                        }
                    }
                    // from second to last-1
                    for (int col = 1; col < pattern[row].Length - 1; col++)
                    {
                        if (pattern[row][col] == 'b')
                        {
                            pattern[row][col] = '.';
                            pattern[row][col + 1] = 'b';
                            break;
                        }
                        else if (pattern[row][col] == 'd')
                        {
                            pattern[row][col] = '.';
                            pattern[row][col - 1] = 'd';
                            break;
                        }
                    }

                    // first cell

                    if (nikoladzeDead == false)
                    {
                        if (pattern[row][0] == 'd')
                        {
                            pattern[row][0] = 'b';
                        }
                        else if (pattern[row][0] == 'b')
                        {
                            pattern[row][0] = '.';
                            pattern[row][1] = 'b';
                        }
                        else if (pattern[row][(pattern[row].Length - 1)] == 'b') //last cell
                        {
                            pattern[row][(pattern[row].Length - 1)] = 'd';
                        }
                        else if (pattern[row][(pattern[row].Length - 1)] == 'd')
                        {
                            pattern[row][pattern[row].Length - 1] = '.';
                            pattern[row][pattern[row].Length - 2] = 'd';
                        }
                    }
                }

                // Move Sam 
                if (command == 'U')
                {
                    pattern[samRow - 1][samCol] = 'S';
                    pattern[samRow][samCol] = '.';
                    samRow--;

                }
                else if (command == 'D')
                {
                    pattern[samRow + 1][samCol] = 'S';
                    pattern[samRow][samCol] = '.';
                    samRow++;
                }
                else if (command == 'L')
                {
                    pattern[samRow][samCol - 1] = 'S';
                    pattern[samRow][samCol] = '.';
                    samCol--;
                }
                else if (command == 'R')
                {
                    pattern[samRow][samCol + 1] = 'S';
                    pattern[samRow][samCol] = '.';
                    samCol++;
                }

            }

            string replace = "";

            if (samDead)
            {
                replace = "S";
                Console.WriteLine("Sam died at {0}, {1}", samRow, samCol);
            }
            else
            {
                replace = "N";
                Console.WriteLine("Nikoladze killed!");
            }

            string strPattern = "";
            for (int i = 0; i < pattern.Length; i++)
            {
                for (int j = 0; j < pattern[i].Length; j++)
                {
                    strPattern += pattern[i][j];
                }
                strPattern += "\n";
            }

            Console.WriteLine(Regex.Replace(strPattern, replace, "X"));
        }
    }
}
