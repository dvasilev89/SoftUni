using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1KeyRevolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            long bulletPrice = long.Parse(Console.ReadLine());

            long gunBarrelSize = long.Parse(Console.ReadLine());

            long[] bullets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long[] locks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long intelligenceValue = long.Parse(Console.ReadLine());

            Stack<long> bulletsStack = new Stack<long>(bullets);

            Queue<long> locksQueue = new Queue<long>(locks);            

            bool isUnlocked = false;

            long counter = gunBarrelSize;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bulletsStack.Pop();
                    Console.WriteLine("Ping!");
                }

                counter--;

                if (counter == 0 && bulletsStack.Count > 0)
                {
                    counter = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }

                if (locksQueue.Count == 0)
                {
                    isUnlocked = true;
                    break;
                }

                if (bulletsStack.Count == 0)
                {
                    break;
                }
            }

            if (isUnlocked)
            {
                long result = (intelligenceValue - ((bullets.Length - bulletsStack.Count) * bulletPrice));
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${result}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
