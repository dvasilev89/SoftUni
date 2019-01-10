using System;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            string driver = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driver);

            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrake()}/{ferrari.PushTheGasPedal()}/{ferrari.Driver}");
        }
    }
}
