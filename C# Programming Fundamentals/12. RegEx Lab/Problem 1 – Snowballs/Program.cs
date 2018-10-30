using System;
using System.Numerics;


class Program
{
    static void Main(string[] args)
    {
        int numberOfSnowballs = int.Parse(Console.ReadLine());

        int snowballSnow = 0;
        int snowballBestSnow = 0;
        int snowballTime = 0;
        int snowballBestTime = 0;
        int snowballQuality = 0;
        int snowballBestQuality = 0;
        BigInteger snowballValue = 0;
        BigInteger snowballBestValue = 0;

        for (int i = 0; i < numberOfSnowballs; i++)
        {
            snowballSnow = int.Parse(Console.ReadLine());
            snowballTime = int.Parse(Console.ReadLine());
            snowballQuality = int.Parse(Console.ReadLine());

            snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue >= snowballBestValue)
            {
                snowballBestSnow = snowballSnow;
                snowballBestTime = snowballTime;
                snowballBestQuality = snowballQuality;
                snowballBestValue = snowballValue;
            }            
        }

        Console.WriteLine($"{snowballBestSnow} : {snowballBestTime} = {snowballBestValue} ({snowballBestQuality})");
    }
}


