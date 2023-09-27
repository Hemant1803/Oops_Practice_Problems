using System;

namespace OOP_Practice_Problem
{
    internal class Program
    {
       public static void Main(string[] args)
        {


            Constructors person1 = new Constructors();
            person1.Display(); 

            Constructors person2 = new Constructors("Prashant", 6000);
            person2.Display();

            

        }
    }
}