using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int credits = 0;
            int input = 0;
            double Totalscore = 0.0;
            double TotalCredits = 0.0;
            int score = 0;

            int iterations = 0;

            for (int i = 1; i <= n; i++)
            {
                iterations = i;
                input = int.Parse(Console.ReadLine());
                credits = (input / 10);
                score = (input % 10);
                Totalscore += score;

                if (score == 3)
                {
                    TotalCredits += credits * 0.5;
                }
                else if (score == 4)
                {
                    TotalCredits += credits * 0.7;
                }
                else if (score == 5)
                {
                    TotalCredits += credits * 0.85;
                }
                else if (score == 6)
                {
                    TotalCredits += credits;
                }
            }
            Totalscore = Totalscore / iterations;
            Console.WriteLine("{0:f2}",TotalCredits);
            Console.WriteLine("{0:f2}",Totalscore);

        }
    }
}
