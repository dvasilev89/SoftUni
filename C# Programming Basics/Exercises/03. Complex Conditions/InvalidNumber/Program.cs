using System;




class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        bool invalid = (a >= 100 && a <= 200 || a == 0);
        
        if (!invalid)
        {
            Console.WriteLine("invalid");
        }
        else
            Console.WriteLine("");
    }
}