using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam3CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupsArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bottlesArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int wastedLittersOfWater = 0;

            bool isCupsFilld = false;
            bool isOutOfBottles = false;

            Stack<int> bottles = new Stack<int>(bottlesArray);
            Queue<int> cups = new Queue<int>(cupsArray);

            for (int i = 0; i < bottles.Count; i++)
            {

                if (cups.Count == 0)
                {
                    isCupsFilld = true;
                    break;
                }

                if (bottles.Count == 0)
                {
                    isOutOfBottles = true;
                    break;
                }

                int currentCup = cups.Peek();

                if (bottles.Peek() >= currentCup)
                {
                    wastedLittersOfWater += bottles.Peek() - cups.Peek();                    
                    cups.Dequeue();
                    bottles.Pop();
                    i--;
                }
                else
                {
                    while(currentCup > 0)
                    {
                        if (bottles.Count == 0)
                        {
                            isOutOfBottles = true;
                            break;
                        }

                        currentCup -= bottles.Pop();
                        i--;
                    }

                    cups.Dequeue();
                    wastedLittersOfWater += Math.Abs(currentCup);
                }

                
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");           

        }
    }
}
