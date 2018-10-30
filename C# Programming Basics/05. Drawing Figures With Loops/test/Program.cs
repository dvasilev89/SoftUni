using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;

            for (int c = 1, j = 3; c <= n - 3; c += 2, j--)
            {
                Console.WriteLine("*" + new string('.', i) + "*" + new string(' ', j) + "*" + new string('.', c) + "*" + new string(' ', j) + "*" + new string('.', i) + "*");
            }
        }
    }
}
