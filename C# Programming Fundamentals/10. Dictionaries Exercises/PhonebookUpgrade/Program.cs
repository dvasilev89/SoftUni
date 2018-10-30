using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();


        string input = "";

        while ((input == "END") == false)
        {
            input = Console.ReadLine();

            List<string> comand = input.Split().ToList();

            comand.AddRange(new string[3] { "0", "0", "0" });

            string addOrSearch = comand[0];
            string name = comand[1];
            string phone = comand[2];

            if (addOrSearch == "A")
            {
                if (phoneBook.ContainsKey(name) == false)
                {
                    phoneBook.Add(name, phone);
                }
                phoneBook[name] = phone;
            }
            else if (addOrSearch == "S")
            {
                foreach (var contact in phoneBook)
                {
                    if (name == contact.Key)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                if (phoneBook.ContainsKey(name) == false)
                {
                    Console.WriteLine("Contact {0} does not exist.", name);
                }
            }
            else if (addOrSearch == "ListAll")
            {
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }
        }
    }
}