using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceList
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public Employee(int id, string name, float salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        
        public void IncreaseSalary(float percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
