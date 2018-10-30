using System;



class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int hours = num1;
        int minutes = num2 + 30;    
        
        if (minutes > 59)
        {
            hours += 1;
            minutes -= 60;
        }
        if (hours > 23)
        {
            if (minutes <= 9)
            {
                Console.WriteLine("0:0{0}", minutes);
            }
            else
            {
                Console.WriteLine("0:{0}", minutes);
            }
        }
        else
        {
            if (minutes <= 9)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }       
    }
}

