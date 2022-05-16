using System;

namespace Constructor
{
    class Program
    {
        //chainning constructors together
        static void Main(string[] args)
        {
            Console.WriteLine("First construct!");
            Employee a = new Employee();
            Console.WriteLine("Second construct!");
            Employee b = new Employee("Steve");
            Console.WriteLine("Third construct!");
            Employee c = new Employee("Steve", 5);
        }
    }
}
