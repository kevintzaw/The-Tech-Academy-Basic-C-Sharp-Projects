using System;

namespace Daily_Submission_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name
            Console.WriteLine("What is your Name?");
            string whatIsName = Console.ReadLine();
            Console.WriteLine("Your name is: " + whatIsName);

            //Course
            Console.WriteLine("What course are you on?");
            int whatIsCourse = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're on course number:" + whatIsCourse);

            //Page Number
            Console.WriteLine("What Page Number are you on?");
            int whatIsPageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're on page number:" + whatIsPageNumber);

            //Do You Need Help?
            Console.WriteLine("What is your Name? Please Answer with True or False");
            string doYouNeedHelp = Console.ReadLine();
            Console.WriteLine("You Need Help?: " + doYouNeedHelp);

            //Did you Have Positive Experiences?
            Console.WriteLine("What are your positive experiences? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("You said about this on your experience: " + positiveExperience);

            //Did you Have Feedback?
            Console.WriteLine("Do you have any feedback? Please give specifics.");
            string doYouHaveFeedback = Console.ReadLine();
            Console.WriteLine("This is the feedback you provided: " + doYouHaveFeedback);

            //How Many Hours did you Study?
            Console.WriteLine("How many hours did you study?");
            int hoursOfStudy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You studied this many hours" + hoursOfStudy);

            // Thank You
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!")
        }
    }
}
