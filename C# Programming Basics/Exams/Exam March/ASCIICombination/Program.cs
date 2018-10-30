using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int numbers = 0;
        int uppers = 0;
        int lowers = 0;
        int symbols = 0;
        string String_numbers = "";
        string String_uppers = "";
        string String_lowers = "";
        string String_symbols = "";


        for (int i = 1; i <= n; i++)
        {
            char cha = char.Parse(Console.ReadLine());

            if (cha >= 48 && cha <= 57)
            {
                numbers += cha;
                String_numbers += cha;
            }
            else if (cha >= 65 && cha <= 90)
            {
                uppers += cha;
                String_uppers += cha;
            }
            else if (cha >= 97 && cha <= 122)
            {
                lowers += cha;
                String_lowers += cha;
            }
            else
            {
                symbols += cha;
                String_symbols += cha;
            }            
        }
        int maxN = Math.Max(Math.Max(numbers, uppers), Math.Max(lowers, symbols));
        string FinalString = "";
        if (numbers == maxN)
        {
            FinalString = String_numbers;
        }
        else if (uppers == maxN)
        {

            FinalString = String_uppers;
        }
        else if (lowers == maxN)
        {

            FinalString = String_lowers;
        }
        else
        {

            FinalString = String_symbols;
        }
        Console.WriteLine("Biggest ASCII sum is:{0}", maxN);
        Console.WriteLine("Combination of characters is:{0}", FinalString);
    }
}

