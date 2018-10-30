using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex = Console.ReadLine();
            double kilos = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string activity = Console.ReadLine();
            double BNM = 0.0;
            if (sex == "m")
            {
                BNM = 66 + (13.7 * kilos) +(5 *(meters*100)) -(6.8 * age);
            }
            else
            {
                BNM = 655 + (9.6 * kilos) + (1.8 * (meters * 100)) - (4.7 * age);
            }

            if (activity == "sedentary")
            {
                BNM *=1.2;
            }
            else if (activity == "lightly active")
            {
                BNM *=1.375;
            }
            else if (activity == "moderately active")
            {
                BNM *=1.55;
            }
            else
            {
                BNM *=1.725;
            }

            BNM = Math.Ceiling(BNM);

            Console.WriteLine("To maintain your current weight you will need {0} calories per day.",(int) BNM);
        }
    }
}
