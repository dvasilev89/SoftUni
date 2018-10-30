using System;



class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int area = r * c;

        switch (type)
        {
            case "premiere":
                {
                    Console.WriteLine("{0:f2} leva", area * 12.00);
                    break;
                }
            case "normal":
                {
                    Console.WriteLine("{0:f2} leva", area * 7.50);
                    break;
                }
            case "discount":
                {
                    Console.WriteLine("{0:f2} leva", area * 5.00);
                    break;
                }
        }
    }
}

