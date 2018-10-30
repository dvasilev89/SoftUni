using System;

namespace ExcelRes
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            double bonusScore = 0;

            if (score > 1000)
            {
                bonusScore = score * 0.1;                
            }
            else if (score > 100)
            {
                bonusScore = score * 0.2;
            }
            else if (score <= 100)
            {
                bonusScore = 5;
            } 
            
            if (score % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (score % 10 == 5)
            {
                bonusScore += 2;
            }

            double totalScore = score + bonusScore;

            Console.WriteLine(bonusScore);
            Console.WriteLine(totalScore);
        }
    }
}