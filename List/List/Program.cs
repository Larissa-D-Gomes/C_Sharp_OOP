using System;
using System.Collections.Generic;
using System.Globalization;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int quant = int.Parse(Console.ReadLine());

            List<Employee> listEmp = new List<Employee>();
            int id;
            string name;
            double salary;

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}:");

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmp.Add(new Employee(id, name, salary));
                Console.WriteLine("");
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            Employee emp = listEmp.Find(x => x.Id == id);

            if(emp != null)
            {
                Console.Write("Enter the percentage:  ");
                double ic = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(ic);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("");
            Console.WriteLine("Updated list of employees:");

            foreach (Employee e in listEmp)
                Console.WriteLine(e);
        }
    }
}
