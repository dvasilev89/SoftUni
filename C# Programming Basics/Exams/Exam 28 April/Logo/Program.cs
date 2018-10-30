using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2 * n - 2, j = 2; i >= 1; i-=2, j+=2)
            {
                Console.WriteLine("{0}{1}",new string(' ',i),new string('*',j));
            }


            Console.WriteLine(new string('*', 2 * n));
            Console.WriteLine(new string('*', 2 * n-2));
            Console.WriteLine(new string('*', 2 * n-4));
            Console.WriteLine(new string('*', 2 * n-2));
            Console.WriteLine(new string('*', 2 * n));
            Console.WriteLine("" + new string(' ', 2) + new string('*', 2 * n-2));
            Console.WriteLine("" + new string(' ', 4) + new string('*', 2 * n-4));
            Console.WriteLine("" + new string(' ', 2) + new string('*', 2 * n-2));
            Console.WriteLine(new string('*', 2 * n));












            for (int i = 2*n-2, j = 1; i >= 2; i-=2, j+=2)
            {
                Console.WriteLine("{0}{1}", new string('*', i), new string(' ', j));
            }
        }
    }
}
