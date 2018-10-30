using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {                  
            BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());            

            List<BigInteger> resultNumbers = new List<BigInteger>();
            Queue<BigInteger> queue = new Queue<BigInteger>();

            queue.Enqueue(inputNumber);
            resultNumbers.Add(inputNumber);

            for (int i = 0; i < 17; i++)
            {
                BigInteger currentNumber = queue.Dequeue();

                BigInteger a = currentNumber + 1;
                BigInteger b = currentNumber * 2 + 1;
                BigInteger c = currentNumber + 2;

                queue.Enqueue(a);
                queue.Enqueue(b);
                queue.Enqueue(c);

                resultNumbers.Add(a);
                resultNumbers.Add(b);
                resultNumbers.Add(c);
            }

            Console.WriteLine(string.Join(" ", resultNumbers.Take(50)));
        }
    }
}
