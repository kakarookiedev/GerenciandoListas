using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeListas
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public double Increase(double percentage)
        {
            return Salary += Salary * (percentage / 100);
        }
        public override string ToString()
        {
            return $"ID: {Id}, NAME: {Name}, SALARY R${Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }



}
