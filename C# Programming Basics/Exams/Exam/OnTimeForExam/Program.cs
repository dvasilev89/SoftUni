using System;




class Program
{
    static void Main(string[] args)
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minutesExam = int.Parse(Console.ReadLine());
        int hourArrival = int.Parse(Console.ReadLine());
        int minutesArrival = int.Parse(Console.ReadLine());

        int examTotalMinutes = ((hourExam * 60) + minutesExam);
        int arrivalTotalMinutes = ((hourArrival * 60) + minutesArrival);

        if (arrivalTotalMinutes > examTotalMinutes)
        {
            Console.WriteLine("Late");
        }
        else if (arrivalTotalMinutes <= examTotalMinutes && arrivalTotalMinutes >= examTotalMinutes - 30)
        {
            Console.WriteLine("On time");
        }
        else if (arrivalTotalMinutes <= examTotalMinutes - 30)
        {
            Console.WriteLine("Early");
        }
        
        if (arrivalTotalMinutes > examTotalMinutes - 60 && arrivalTotalMinutes < examTotalMinutes)       
        {
            Console.WriteLine("{0} minutes before the start", (examTotalMinutes - arrivalTotalMinutes) % 60);
        }
        else if (arrivalTotalMinutes <= examTotalMinutes - 60)
        {
            int minutes = ((examTotalMinutes - arrivalTotalMinutes) % 60);
            int hours = ((examTotalMinutes - arrivalTotalMinutes) / 60);

            if (minutes <= 9 && minutes >=0)
            {
                Console.WriteLine("{0}:0{1} hours before the start", hours, minutes);
            }
            else
                Console.WriteLine("{0}:{1} hours before the start", hours, minutes);
        }
        else if (arrivalTotalMinutes < examTotalMinutes + 60 && arrivalTotalMinutes > examTotalMinutes)
        {
            Console.WriteLine("{0} minutes after the start", (arrivalTotalMinutes - examTotalMinutes) % 60);
        }
        else if (arrivalTotalMinutes >= examTotalMinutes + 60)
        {
            int minutes = ((arrivalTotalMinutes - examTotalMinutes) % 60);
            int hours = ((arrivalTotalMinutes - examTotalMinutes) / 60);

            if (minutes <= 9 && minutes >= 0)
            {
                Console.WriteLine("{0}:0{1} hours after the start", hours, minutes);
            }
            else
                Console.WriteLine("{0}:{1} hours after the start", hours, minutes);
        }
    }
}

