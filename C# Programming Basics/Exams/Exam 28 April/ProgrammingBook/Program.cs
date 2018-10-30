using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePage = double.Parse(Console.ReadLine());
            double coverPrice = double.Parse(Console.ReadLine());
            int PaperPercent = int.Parse(Console.ReadLine());
            double Designer = double.Parse(Console.ReadLine());
            int TeamPercent = int.Parse(Console.ReadLine());

            //double pricePage = 0.02;
            //double coverPrice = 0.50;
            //int PaperPercent = 18;
            //double Designer = 21;
            //int TeamPercent = 50;

            double totalprice = pricePage * 899.0 + coverPrice * 2.0;
            totalprice = totalprice * ((100-PaperPercent) / 100.0);
            totalprice += Designer;
            totalprice = totalprice * ((100-TeamPercent) / 100.0);
            Console.WriteLine("Avtonom should pay {0:f2} BGN.",totalprice);
        }
    }
}
