using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBirthdate> allDates = new List<IBirthdate>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArrgs = input.Split();

                if (inputArrgs[0] == "Citizen")
                {
                    string name = inputArrgs[1];
                    string age = inputArrgs[2];
                    string id = inputArrgs[3];
                    string birthdate = inputArrgs[4];

                    allDates.Add(new Citizens(name, age, id, birthdate));
                }
                else if (inputArrgs[0] == "Pet")
                {
                    string name = inputArrgs[1];
                    string birthdate = inputArrgs[2];
                    allDates.Add(new Pet(name, birthdate));
                }

                input = Console.ReadLine();
            }

            int yearToFind = int.Parse(Console.ReadLine());

            allDates.Where(x => x.Birthdate.Year == yearToFind)
                .Select(x => x.Birthdate)
                .ToList()
                .ForEach(dt => Console.WriteLine($"{dt:dd/mm/yyyy}"));
        }
    }
}
