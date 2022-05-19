using System;

namespace Constructor
{
    class Program
    {
        //chainning constructors together
        static void Main(string[] args)
        {
            var empObj = new Employee("Kevin");
            Console.WriteLine("Employee's name: " + empObj.employeeName + ". Employee's Number: " + empObj.employeeNumber);
            Console.ReadLine();
        }
    }
}
