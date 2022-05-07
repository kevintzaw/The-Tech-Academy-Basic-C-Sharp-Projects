using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //instantiating Employee object with first and last name
            Employee examplePerson = new Employee();
            examplePerson.firstName = "Sample";
            examplePerson.lastName = "Student";
            //calling the SayName method
            examplePerson.SayName();
        }
    }
}
