using OOP_Practice_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice_Problem
{
    internal class Constructors
    {
       
              string name;
              int salary;

      
        public Constructors()
        {
            name = "Hemant";
            salary = 50000;
        }

        // Parameterized Constructor
        public Constructors(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {name}, Salary: {salary}");
        }
    }
}

