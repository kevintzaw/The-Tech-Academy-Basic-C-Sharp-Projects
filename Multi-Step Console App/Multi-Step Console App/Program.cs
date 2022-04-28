using System;

namespace Multi_Step_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring single dimension array
            string[] People = new string[3];
            People[0] = "Mike";
            People[1] = "Tom";
            People[2] = "Stephanie";

            //Asking User to input text
            string userInput;
            Console.Write("Enter an adjective: ");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered " + userInput);

            //loop through text
            for (int i = 0; i < People.Length; i++)
            {
                Console.WriteLine(People[i]);
            }

            //infinite loop
            while(true)
            {
                Console.WriteLine("Hello! This is an infinite loop!");
            }

            //loop with < operator
            for (int i=0; i<2; i++)
            {
                Console.WriteLine(People[i]);
            }

            //loop with a <= operator
            for (int i=0; i<=2; i++)
            {
                Console.WriteLine(People[i]);
            }

            //loop until finds text in string
            string[] size = { "large", "medium", "small" };
            for (int j=0; j<size.Length; j++)
            {
                //Asking User to input text
                string inputSize;
                Console.Write("Enter an adjective: ");
                userInput = Console.ReadLine();
                Console.WriteLine("You entered " + inputSize);

                //comparison
                if (size[j] == inputSize)
                {
                    Console.WriteLine(size[j]);
                }
                else
                {
                    Console.WriteLine("That size value is not recognized");
                }
            }

            //loop with identical strings
            List<int> seasons = new List<int>() { "winter", "summer", "spring", "winter" };

            //Asking User to input text
            string inputSeason;
            Console.Write("Pick a season: ");
            userInput = Console.ReadLine();
            Console.WriteLine("You entered " + inputSeason);

            ////////STUCK HERE////////
            //loop through list
            foreach (int items in seasons)
            {
                if (userInput ==)
            }
        }
    }
}
