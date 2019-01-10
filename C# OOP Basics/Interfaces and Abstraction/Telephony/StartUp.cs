using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (string number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            foreach (string url in urls)
            {
                Console.WriteLine(smartphone.Browse(url));
            }
        }
    }
}
