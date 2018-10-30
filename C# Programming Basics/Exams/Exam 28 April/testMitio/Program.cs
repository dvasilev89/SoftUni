using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 145;
            double result = 0.0;
            double test = 0.0;
            for (int a = 1; a <= 9; a++)
            {
                if (result != 0.0)
                    break;
                for (int b = 4; b <= 97-9; b++)
                {
                    if (result != 0.0)
                        break;
                    for (int c = 0; c <= 9; c++)
                    {
                        if (result != 0.0)
                            break;
                        for (int d = 1; d <= 99 -9; d++)
                        {
                            if ((a + b + c + d) == (a * b * c * d) ) //  &&(n % 10 == 5 )
                            {
                                result = a * 1000 + b * 100 + c * 10 + d + 1000;
                                break;
                            }
                            /*
                            else if ((int)(a * b * c * d / (a + b + c + d)) == 3 && n % 3 == 0)
                            {
                                //result = a * 1000 + b * 100 + c * 10 + d;
                                result = d * 1000 + c * 100 + b * 10 + a;
                                break;
                            }
                            */

                        }
                    }
                }
            }
            if (result != 0.0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Nothing found");
            }
        }
    }
}
