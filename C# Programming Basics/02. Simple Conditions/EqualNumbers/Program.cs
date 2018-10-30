using System;



class Program
{
    static void Main(string[] args)
    {
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());
        double numTree = double.Parse(Console.ReadLine());

        if (numOne == numTwo)
        {
            if (numTwo == numTree)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
        
    }
}