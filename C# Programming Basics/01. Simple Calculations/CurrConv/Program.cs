using System;


class Program
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());

        string inputCurrency = Console.ReadLine();

        string outputCurrency = Console.ReadLine();

        double resultInBGN = 0;

        if (inputCurrency == "BGN")
        {
            resultInBGN = money;
        }
        else if (inputCurrency == "USD")
        {
            resultInBGN = money * 1.79549;
        }
        else if (inputCurrency == "EUR")
        {
            resultInBGN = money * 1.95583;
        }
        else if (inputCurrency == "GBP")
        {
            resultInBGN = money * 2.53405;
        }

        double resultInOutputCurrency = 0;

        if (outputCurrency == "BGN")
        {
            resultInOutputCurrency = resultInBGN;
        }
        else if (outputCurrency == "USD")
        {
            resultInOutputCurrency = resultInBGN / 1.79594;
        }
        else if (outputCurrency == "EUR")
        {
            resultInOutputCurrency = resultInBGN / 1.95583;
        }
        else if (outputCurrency == "GBP")
        {
            resultInOutputCurrency = resultInBGN / 2.53405;
        }

            Console.WriteLine("{0:f2} {1}", resultInOutputCurrency, outputCurrency);
                    
    }
}