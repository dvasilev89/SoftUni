using System;



class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine().ToLower();
        int nights = int.Parse(Console.ReadLine());

        double studio = 0.0;
        double doubleRoom = 0.0;
        double suite = 0.0;

        if (month == "may" || month == "october")
        {
            studio += 50;
            doubleRoom += 65;
            suite += 75;
        }
        else if (month == "june" || month == "september")
        {
            studio += 60;
            doubleRoom += 72;
            suite += 82;
        }
        else if (month == "july" || month == "august" || month == "december")
        {
            studio += 68;
            doubleRoom += 77;
            suite += 89;
        }
                
        if (nights > 7 && (month == "may" || month == "october"))
        {
            studio = studio - (studio * 0.05);            
        }
        if (nights > 14)
        {
            if (month == "june" || month == "september")
            {
                doubleRoom = doubleRoom - (doubleRoom * 0.1);
            }
            if (month == "july" || month == "august" || month == "december")
            {
                suite = suite - (suite * 0.15);
            }
        }

        if (nights > 7 && (month == "september" || month == "october"))
        {
            Console.WriteLine("Studio: {0:f2} lv.", studio * (nights - 1));
            Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nights);
            Console.WriteLine("Suite: {0:f2} lv.", suite * nights);
        }
        else
        {
            Console.WriteLine("Studio: {0:f2} lv.", studio * nights);
            Console.WriteLine("Double: {0:f2} lv.", doubleRoom * nights);
            Console.WriteLine("Suite: {0:f2} lv.", suite * nights);
        }
        

    }
}

