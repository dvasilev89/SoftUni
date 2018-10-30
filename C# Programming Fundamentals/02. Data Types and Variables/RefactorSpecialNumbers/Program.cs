using System;


    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0; int firstDigit = 0; bool result = false;

            for (int i = 1; i <= num; i++)
            {
                firstDigit = i;
                while (i > 0)
                {                
                sum = (i % 10) + (i / 10);
                }
                result = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{firstDigit} -> {result}");            
            }
        }
    }


