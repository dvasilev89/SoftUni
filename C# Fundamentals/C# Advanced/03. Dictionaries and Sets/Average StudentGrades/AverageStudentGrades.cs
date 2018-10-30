using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsBook = new Dictionary<string, List<double>>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = input[0];
                double grade = double.Parse(input[1]);

                if (studentsBook.ContainsKey(studentName) == false)
                {
                    studentsBook.Add(studentName, new List<double>());
                }

                studentsBook[studentName].Add(grade);
            }

            foreach (var student in studentsBook)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
