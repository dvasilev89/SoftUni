using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            Stack<long> fibonacciStack = new Stack<long>();

            fibonacciStack.Push(0);
            fibonacciStack.Push(1);

            long lastNumber = 0L;
            long firstNumber = 0L;

            for (int i = 0; i < input; i++)
            {
                lastNumber = fibonacciStack.Pop();
                firstNumber = fibonacciStack.Pop();

                fibonacciStack.Push(lastNumber);
                fibonacciStack.Push(firstNumber + lastNumber);
            }

            fibonacciStack.Pop();

            Console.WriteLine(fibonacciStack.Pop());            
        }
    }
}
