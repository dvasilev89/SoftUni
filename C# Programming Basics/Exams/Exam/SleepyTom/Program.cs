using System;



class Program
{
    static void Main(string[] args)
    {
        int freeDays = int.Parse(Console.ReadLine());

        int workDays = 365 - freeDays;
        int playTime = workDays * 63 + freeDays * 127;
        

        if (playTime > 30000)
        {
            int overTime = playTime - 30000;
            int hours = overTime / 60;
            int minutes = overTime % 60;
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
        }
        if (playTime < 30000)
        {
            int overTime = 30000 - playTime;
            int hours = overTime / 60;
            int minutes = overTime % 60;
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
        }
    }    
}
