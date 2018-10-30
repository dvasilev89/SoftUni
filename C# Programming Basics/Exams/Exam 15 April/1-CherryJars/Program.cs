using System;


class Program
{
    static void Main(string[] args)
    {
        int kompotQuantity = int.Parse(Console.ReadLine());
        int komfitiurQuantity = int.Parse(Console.ReadLine());

        double kompotCherryQuantity = (((kompotQuantity + 1) * 0.3) + (0.05 * ((kompotQuantity + 1) * 0.3)));
        double sweetCherryQuantity = (((komfitiurQuantity + 1) * 0.65) + (0.1 * ((komfitiurQuantity + 1) * 0.65)));

        double totalCherry = kompotCherryQuantity + sweetCherryQuantity;
        double totalPrice = totalCherry * 3.2;

        Console.WriteLine("{0:f2}", totalPrice);
    }
}

