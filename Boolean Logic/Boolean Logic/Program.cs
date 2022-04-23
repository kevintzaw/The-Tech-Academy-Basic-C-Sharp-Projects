using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age
            Console.WriteLine("What is your Age?");
            int whatIsAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Age is: " + whatIsAge); ;

            //DUI
            Console.WriteLine("Have you ever had a DUI? Please answer with True Or False");
            bool doYouHaveDUI = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("You said that you have a DUI: " + doYouHaveDUI);

            //Speeding Tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have this many Speeding Tickets:" + speedingTicket);

            //Qualified
            bool qualifiedResult = (whatIsAge >= 15 && doYouHaveDUI == false && 3 >= speedingTicket);
            Console.WriteLine("You can drive a car: " + qualifiedResult);
        }
    }
}
