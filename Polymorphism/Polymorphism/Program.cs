using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //trying to create instance of Interface
            IQuittable newObj = new IQuittable();
            //called method
            newObj.Quit();

        }
    }
}
