using System;


class Program
{
    static void Main(string[] args)
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();

        bool isByte = byte.TryParse(firstNum, out byte sbyteNum);

        if (isByte)
        {
            int intNum = int.Parse(secondNum);
            long result = (sbyteNum * 4) + (intNum * 10L);
            Console.WriteLine(result);
        }
        else
        {
            int intNum = int.Parse(firstNum);
            byte sbyteParse = byte.Parse(secondNum);
            long result = (sbyteParse * 4) + (intNum * 10L);
            Console.WriteLine(result);
        }
      
    }
}

