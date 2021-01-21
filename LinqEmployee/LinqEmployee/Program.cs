using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using LinqEmployee.Entities;

namespace LinqEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                try
                {
                    while (!sr.EndOfStream)
                    {
                        string[] l = sr.ReadLine().Split(',');
                        list.Add(new Employee(l[0], l[1], double.Parse(l[2], CultureInfo.InvariantCulture)));
                    }
                }
                catch(IOException e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emails = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);

            Console.WriteLine("Email of people whose salary is more than 2000.00:");
            foreach(var e in emails)
                Console.WriteLine(e);

            double sum = list.Where(p => p.Name.ToUpper()[0] == 'M').Sum(p => p.Salary);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': "
                + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
