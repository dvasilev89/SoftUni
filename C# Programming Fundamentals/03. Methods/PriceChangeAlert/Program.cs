using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double div = DifferenceInPercent(lastPrice, currentPrice);
            bool isSignificantDifference = imaliDif(div, significanceThreshold);
            string message = Get(currentPrice, lastPrice, div, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double result, bool isTrue)
    {
        string total = "";
        if (result == 0)
        {
            total = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isTrue)
        {
            total = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, result);
        }
        else if (isTrue && (result > 0))
        {
            total = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, result);
        }
        else if (isTrue && (result < 0))
            total = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, result);
        return total;
    }

    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double DifferenceInPercent(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) * lastPrice;
        return result;
    }
}
