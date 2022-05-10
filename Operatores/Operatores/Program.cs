using System;

namespace Operatores
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newobj = new Employee(15, 25);

            //overloading operators
            _ = newobj == newobj;

            Console.WriteLine("Hello World!");
        }
    }
}
