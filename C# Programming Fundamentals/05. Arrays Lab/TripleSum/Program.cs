using System;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        int[] n = Console.ReadLine().Split()
            .Select((e=> int.Parse(e)))
            .ToArray();

        int count = 0;

        for (int i = 0; i < n.Length; i++)
        {
            for (int j = i + 1; j < n.Length; j++)
            {
                for (int k = 0; k < n.Length; k++)
                {
                    int a = n[i];
                    int b = n[j];
                    int c = n[k];                   
                    
                    if (a + b == c)
                    {
                        Console.WriteLine($"{a} + {b} == {c}");                        
                        count++;
                        break;
                    }                    
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

