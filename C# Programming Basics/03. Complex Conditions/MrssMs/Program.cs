using System;




class Program
{
    static void Main(string[] args)
    {
        double age = double.Parse(Console.ReadLine());
        string pronaunse = Console.ReadLine();

        if (pronaunse == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
        }
        else if (pronaunse == "f")
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }

    }
}