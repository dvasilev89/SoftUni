using System;


class Program
{
    static void Main(string[] args)
    {
        double meters = double.Parse(Console.ReadLine());

        string inputMetric = Console.ReadLine().ToLower();

        string outputMetric = Console.ReadLine().ToLower();

        double resultInMeters = 0;

        if (inputMetric == "m")
        {
            resultInMeters = meters;
        }
        else if (inputMetric == "mm")
        {
            resultInMeters = meters / 1000;
        }
        else if (inputMetric == "cm")
        {
            resultInMeters = meters / 100;
        }
        else if (inputMetric == "mi")
        {
            resultInMeters = meters / 0.000621371192;
        }
        else if (inputMetric == "in")
        {
            resultInMeters = meters / 39.3700787;
        }
        else if (inputMetric == "km")
        {
            resultInMeters = meters / 0.001;
        }
        else if (inputMetric == "ft")
        {
            resultInMeters = meters / 3.2808399;
        }
        else if (inputMetric == "yd")
        {
            resultInMeters = meters / 1.0936133;
        }

        double resultOutMeters = 0;

        if (outputMetric == "m")
        {
            resultOutMeters = resultInMeters;
        }
        else if (outputMetric == "mm")
        {
            resultOutMeters = resultInMeters * 1000;
        }
        else if (outputMetric == "cm")
        {
            resultOutMeters = resultInMeters * 100;
        }
        else if (outputMetric == "mi")
        {
            resultOutMeters = resultInMeters * 0.000621371192;
        }
        else if (outputMetric == "in")
        {
            resultOutMeters = resultInMeters * 39.3700787;
        }
        else if (outputMetric == "km")
        {
            resultOutMeters = resultInMeters * 0.001;
        }
        else if (outputMetric == "ft")
        {
            resultOutMeters = resultInMeters * 3.2808399;
        }
        else if (outputMetric == "yd")
        {
            resultOutMeters = resultInMeters * 1.0936133;
        }

        Console.WriteLine("{0:f8}", resultOutMeters);
    }
}