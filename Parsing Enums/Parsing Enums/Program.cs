using System;

namespace Parsing_Enums
{
    class Program
    {
        //enum for days of the week
        enum daysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //user inputs value
            Console.WriteLine("Enter the current day of the week");
            string current = Console.ReadLine();

            try
            {

                foreach (string days in daysoftheWeek)
                {
                    daysoftheWeek current = daysoftheWeek.days;
                }
            }
            catch
            {
                Console.WriteLine("A day of the week needs to be entered");
                Console.ReadLine();
            }
            
        }
    }
}
