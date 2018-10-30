using System;


class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());        

        for (int i = 1; i <= num; i++)
        {
            bool isPalindrome = IsPalindrome(i);
            bool sumOfDigits = SumOfDigits(i);
            bool containsEvenDigit = ContainsEvenDigit(i);

            if (isPalindrome && sumOfDigits && containsEvenDigit)
            {
                Console.WriteLine(i);
            }
        }

    }

    static bool ContainsEvenDigit(int num)
    {
        bool evenDigit = false;

        while (num > 0)
        {
            int digit = num % 10;

            if (digit % 2 == 0)
            {
                evenDigit = true;
                break;
            }

            num /= 10;
        }

        return evenDigit;
    }

    static bool SumOfDigits(int num)
    {
        bool sumOfDigits = false;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;

            num /= 10;
        }

        if (sum % 7 == 0)
        {
            sumOfDigits = true;
        }

        return sumOfDigits;
    }

    static bool IsPalindrome(int num)
    {
        string reversed = "";
        int originalNumber = num;

        while (num > 0)
        {
            int digit = num % 10;
            reversed += digit;

            num /= 10;
        }

        int reversedNumber = int.Parse(reversed);

        bool isPalindrone = (originalNumber == reversedNumber);

        return isPalindrone;
    }
}