using System;

namespace Methods_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee creatingEmployee = new Employee();
            creatingEmployee.FirstName = "Sample";
            creatingEmployee.LastName = "Student";
            Console.WriteLine("Hello World!");
            //calling the superclass
            creatingEmployee.SayName();
        }
    }
}
