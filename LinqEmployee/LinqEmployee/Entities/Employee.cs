﻿
namespace LinqEmployee.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; private set; }

        public Employee(string name, string email, double salary)
        {
            this.Name = name;
            this.Email = email;
            this.Salary = salary;
        }
    }
}
