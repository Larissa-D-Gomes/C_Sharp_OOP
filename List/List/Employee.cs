
using System.Globalization;

namespace List
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name;
        public double Salary { get; private set; } 
        
        /* Construtor classe Employee
         * @param int id, string name, double salary
         */
        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        /* Método para efetuar aumento do salário do funcionário
         * @param double percentage
         */
        public void increaseSalary(double percentage)
        {
            this.Salary = this.Salary + (this.Salary * percentage / 100);
        }

        /*Método ToString*/
        public override string ToString()
        {
            return   this.Id + ", " + this.Name + ", " 
                   + this.Salary.ToString("F2", CultureInfo.InvariantCulture);
        
        }
    }
}
