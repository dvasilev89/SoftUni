using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrangeIntegers
{
    class ArrangeIntegers
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            char[] alphabet = "efnostz".ToCharArray();            

            while (true)
            {
                bool arrangedNum = false;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i].Length > 0)
                    {
                        for (int j = 0; j < numbers[j].Length; j++)
                        {
                            if (numbers[i][j])
                            {
                                arrangedNum = true;
                            }
                        }
                    }

                }

                if (arrangedNum == true)
                {
                    break;
                }
            }




        }
    }
}
