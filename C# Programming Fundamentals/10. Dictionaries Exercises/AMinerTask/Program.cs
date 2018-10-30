using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> resourcesBook = new Dictionary<string, int>();       
        

        while (true)
        {
            string resource = Console.ReadLine();

            if (resource == "stop")
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());

            if (resourcesBook.ContainsKey(resource) == false)
            {
                resourcesBook.Add(resource, quantity);
            }
            else
            {
                resourcesBook[resource] += quantity;
            }   
            
        }

        foreach (KeyValuePair<string, int> item in resourcesBook)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}