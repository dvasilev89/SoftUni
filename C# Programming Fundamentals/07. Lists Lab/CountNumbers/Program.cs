using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

        input.Sort();        

        var groups = input.GroupBy(x => x);
        
        foreach (var group in groups)
        {
            Console.WriteLine("{0} -> {1}", group.Key, group.Count());
        }
    }
}

