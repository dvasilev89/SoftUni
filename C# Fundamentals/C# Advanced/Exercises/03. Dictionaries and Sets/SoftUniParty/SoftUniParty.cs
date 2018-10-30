using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input == "PARTY")
                {
                    break;
                }

                bool isDigit = int.TryParse(input[0].ToString(), out int result);

                if (isDigit)
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

            }

            while (true)
            {
                string partyPeople = Console.ReadLine();

                if (partyPeople == "END")
                {
                    break;
                }

                bool isDigit = int.TryParse(partyPeople[0].ToString(), out int result);

                if (isDigit)
                {
                    vipGuests.Remove(partyPeople);
                }
                else
                {
                    regularGuests.Remove(partyPeople);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var reguler in regularGuests)
            {
                Console.WriteLine(reguler);
            }
        }
    }
}
