using System;

namespace While_Practice_Project
{
    class Program
    {
        static void Main(string[] args)
        {   
            // While Statement
            Console.WriteLine("How Old Are You?");

            int howOldAreYou = Convert.ToInt32(Console.ReadLine());
            while (howOldAreYou > 20)
            {
                Console.WriteLine(howOldAreYou);
                howOldAreYou++;
            }

            //Do While Statement
            Console.WriteLine("How Old is Your Pet?");

            int howOldisPet = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(howOldisPet);
                howOldisPet++;
            }
            while (howOldisPet < 10);
        }
    }
}
