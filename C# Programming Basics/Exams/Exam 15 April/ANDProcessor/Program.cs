using System;


class Program
{
    static void Main(string[] args)
    {
        int processorsPlaned = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());

        int workingHours = workers * days * 8;
        int processorsMade = (int)(workingHours / 3);

        if (processorsMade < processorsPlaned)
        {
            double losses = (processorsPlaned - processorsMade) * 110.10;
            Console.WriteLine("Losses: -> {0:f2} BGN", losses);
        }
        else
        {
            double profit = (processorsMade - processorsPlaned) * 110.10;
            Console.WriteLine("Profit: -> {0:f2} BGN", profit);
        }
    }
}

