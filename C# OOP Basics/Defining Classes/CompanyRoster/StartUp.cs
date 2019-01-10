using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];

                Employee employee = new Employee(name, salary, position, department);

                if (inputArgs.Length == 5)
                {
                    if (int.TryParse(inputArgs[4],out int result))
                    {
                        int age = result;
                        employee.Age = age;
                    }
                    else
                    {
                        string email = inputArgs[4];
                        employee.Email = email;
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    string email = inputArgs[4];
                    employee.Email = email;

                    int age = int.Parse(inputArgs[5]);
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                                         .ToDictionary(x => x.Key, y => y.Select(s => s))
                                         .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                         .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (Employee employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary} {employee.Email} {employee.Age}");
            }
        }
    }
}
