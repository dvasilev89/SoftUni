using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                if (person.Age > 30)
                {
                    family.AddMember(person);
                }
            }

            foreach (var man in family.Persons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{man.Name} - {man.Age}");
            }
        }
    }
}
