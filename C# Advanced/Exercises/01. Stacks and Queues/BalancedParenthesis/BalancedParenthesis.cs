using System;
using System.Collections.Generic;

namespace BalancedParenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            bool isValid = true;

            Stack<char> stackOfParantheses = new Stack<char>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                char currentBracket = input[i];

                if (currentBracket == '(' || currentBracket == '{' || currentBracket == '[')
                {
                    stackOfParantheses.Push(currentBracket);
                    continue;
                }

                if (stackOfParantheses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParantheses.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParantheses.Pop();
                }
                else if (stackOfParantheses.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParantheses.Pop();
                }
                else if (stackOfParantheses.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParantheses.Pop();
                }
            }

            if (isValid && stackOfParantheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
