using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> resourcesBook = new Dictionary<string, string>();


        while (true)
        {
            string name = Console.ReadLine();

            if (name == "stop")
            {
                break;
            }

            string email = Console.ReadLine();

            if (resourcesBook.ContainsKey(name) == false && email.EndsWith('k') == false && email.EndsWith('s') == false)
            {
                resourcesBook.Add(name, email);
            }
            else if (resourcesBook.ContainsKey(name) && email.EndsWith('k') == false && email.EndsWith('s') == false)
            {
                resourcesBook[name] = email;
            }

        }

        foreach (KeyValuePair<string, string> item in resourcesBook)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}