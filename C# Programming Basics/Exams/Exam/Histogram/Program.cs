using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());      

            if (num < 200)
            {
                p1 += 1;
            }
            else if (num >= 200 && num <= 399)
            {
                p2 += 1;
            }
            else if (num >= 400 && num <= 599)
            {
                p3 += 1;
            }
            else if (num >= 600 && num <= 799)
            {
                p4 += 1;
            }
            else if (num >= 800)
            {
                p5 += 1;
            }                       
        }

        double per1 = (p1 / n * 100);
        double per2 = (p2 / n * 100);
        double per3 = (p3 / n * 100);
        double per4 = (p4 / n * 100);
        double per5 = (p5 / n * 100);

        Console.WriteLine("{0:f2}%", per1);
        Console.WriteLine("{0:f2}%", per2);
        Console.WriteLine("{0:f2}%", per3);
        Console.WriteLine("{0:f2}%", per4);
        Console.WriteLine("{0:f2}%", per5);
    }
}

