using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //string for current time
            string dateTime = DateTime.Now.ToString("hh:mm:ss tt");
            Console.WriteLine(dateTime);

            //convert current time to int
            int newCalTime = Convert.ToInt32(dateTime);
            //user input value
            Console.WriteLine("Input a number value here");
            string userInput = Console.ReadLine();
            int userTimeInput = Convert.ToInt32(userInput);

            //calculation
            int intResultTime = userTimeInput + newCalTime;

            //convert Number to Time
            string stringResultTime = intResultTime.ToString();
            Console.WriteLine(stringResultTime);
        }
    }
}
