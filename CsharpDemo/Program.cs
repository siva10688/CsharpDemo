using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);


            var employees = new List<Employee>
            {
                new Employee{Name="Mahesh",Age=29},
                new Employee{Name="Bharath",Age=30}
            };

            Console.WriteLine("Employess Details :");
            employees.ForEach(employee =>
            {
                Console.WriteLine($"Name : {employee.Name}               Age : {employee.Age}");
            });

            var employeesJson = JsonConvert.SerializeObject(employees);

            Console.WriteLine(employeesJson);

            Console.ReadLine(1);
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
