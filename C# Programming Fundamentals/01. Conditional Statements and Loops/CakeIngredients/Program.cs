using System;



class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 21; i++)
        {
            string ingredient = Console.ReadLine();
            

            if (ingredient == "Bake!")
            {
                Console.WriteLine("Preparing cake with {0} ingredients.", (i - 1));
                break;
            }
            else
            {
                Console.WriteLine("Adding ingredient {0}.", ingredient);
            }
        }
    }
}

