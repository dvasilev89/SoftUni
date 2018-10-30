using System;



class Program
{
    static void Main(string[] args)
    {
        string userInput = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < userInput.Length; i++)
        {
            switch (userInput[i])
            {
                case 'a': sum += 1; break;
                case 'e': sum += 2; break;
                case 'i': sum += 3; break;
                case 'o': sum += 4; break;
                case 'u': sum += 5; break;
            }
        }
        Console.WriteLine(sum);
    }
}

