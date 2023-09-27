using System;
using static OOP_Practice_Problem.Interface;

namespace OOP_Practice_Problem
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            for(; ; ) {
                Console.WriteLine("****************************************************************************************************");
                Console.WriteLine("Select the Program You Want To Run");
            Console.WriteLine("\n1.Demonstrate different types of constructors. \n2.Perform interface concept with examples.\n3.Perform access modifiers concepts with examples. ");
            int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Constructors person1 = new Constructors();
                        person1.Display();

                        Constructors person2 = new Constructors("Prashant", 6000);
                        person2.Display();
                        break;

                    case 2:
                        Employees employee = new Employee("Hemant", 50000);

                        employee.DisplayInfo();


                        Console.WriteLine($"Employee Name: {employee.Name}");
                        Console.WriteLine($"Employee Salary: {employee.Salary}");
                        break;
                    case 3:
                        Console.WriteLine("hello");
                        break;
                    case 4:
                        return;



                }

            }
        }
    }
}