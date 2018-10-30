using System;



class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        char d = char.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int counter = 0;        

        for (int i = a; i <= 99; i++)
        {
            if (counter == n)
            {
                break;
            }
            for (int j = b; j <= 90; j++)
            {
                if (counter == n)
                {
                    break;
                }
                for (int k = c; k <= 122; k++)
                {
                    if (counter == n)
                    {
                        break;
                    }
                    for (int l = d; l <= 90; l++)
                    {
                        if (counter == n)
                        {
                            break;
                        }
                        for (int m = e; m >= 10; m--)
                        {
                            if ((i % 10 == 2) && (m % 10 == 5))
                            {
                                counter++;
                            }

                            if (counter == n)
                            {
                                Console.WriteLine("" + i + (char)j + (char)k + (char)l + m);
                                break;
                            }
                            
                        }
                    }
                }
            }
        }
    }
}

