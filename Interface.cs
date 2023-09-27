using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice_Problem
{
    internal class Interface
    {
        public interface Employees
        {
            string Name { get; set; }
            decimal Salary { get; set; }

            void DisplayInfo();
        }

        
        public class Employee : Employees
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }

            public Employee(string name, decimal salary)
            {
                Name = name;
                Salary = salary;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Employee Name: {Name}");
                Console.WriteLine($"Employee Salary: {Salary}");
            }
        }

    }
}
