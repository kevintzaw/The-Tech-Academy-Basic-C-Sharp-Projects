using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //string for current time
            var dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            //user input value
            Console.WriteLine("Input a number value here");
            string userInput = Console.ReadLine();
            int userTimeInput = Convert.ToInt32(userInput);

            Console.WriteLine("{0}+{1} hour(s) = {2}", dateTime, userTimeInput, dateTime.AddHours(userTimeInput));
        }
    }
}
