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
            int n = int.Parse(Console.ReadLine());
            //int n = 145;
            double result = 0.0;
            //double test = 0.0;
            if (n % 10 == 5)
            {
                for (int a = 1; a <= 9 - 1; a++)
                {
                    if (result != 0.0)
                        break;
                    for (int b = 4; b <= (int)'a' - 9; b++)
                    {
                        if (result != 0.0)
                            break;
                        for (int c = 1; c <= 9 - 0; c++)
                        {
                            if (result != 0.0)
                                break;
                            for (int d = 1; d <= (int)'c' - 9; d++)
                            {
                                if ((a + b + c + d) == a * b * c * d && n % 10 == 5)
                                {
                                    result = a * 1000 + b * 100 + c * 10 + d;
                                    //Console.WriteLine("" + a + b + c + d);
                                    Console.WriteLine(result);
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            else if (n % 10 == 3)
            {
                for (int a = 1; a <= 9 - 1; a++)
                {
                    if (result != 0.0)
                        break;
                    for (int b = 4; b <= (int)'a' - 9; b++)
                    {
                        if (result != 0.0)
                            break;
                        for (int c = 1; c <= 9 - 0; c++)
                        {
                            if (result != 0.0)
                                break;
                            for (int d = 1; d <= (int)'c' - 9; d++)
                            {
                                if ((a * b * c * d / (a + b + c + d)) == 3)
                                {
                                    //result = a * 1000 + b * 100 + c * 10 + d;
                                    result = d * 1000 + c * 100 + b * 10 + a;
                                    Console.WriteLine(result);
                                    //Console.WriteLine("" + d + c + b + a);
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Nothing found");
            }


            
        }
    }
}
