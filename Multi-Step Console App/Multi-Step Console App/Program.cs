using System;
using System.Collections.Generic;

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
                People[i] = People[i] + userInput;
            }

            //loop through text
            for (int i = 0; i < People.Length; i++)
            {
                Console.WriteLine(People[i]);
            }

            //infinite loop
            //while(true)
            //{
                //Console.WriteLine("Hello! This is an infinite loop!");
            //}

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

            //Asking User to input text
            Console.Write("Enter an adjective: ");
            string inputSize = Console.ReadLine();
            Console.WriteLine("You entered " + inputSize);

            for (int j=0; j<size.Length; j++)
            {

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
            List<string> seasons = new List<string>() { "winter", "summer", "spring", "winter" };

            //Asking User to input text
            Console.Write("Pick a season: ");
            string inputSeason = Console.ReadLine();
            Console.WriteLine("You entered " + inputSeason);

            //loop through list
            for (int i=0; i<seasons.Count; i++)
            {
                if (seasons[i] == inputSeason)
                {
                    Console.WriteLine(i);
                }
            }

            //list of strings with identical strings
            List<string> cars = new List<string>() { "toyota", "ford", "ford" };
            List<string> carsCopy = new List<string>();

            //iterates through the main list
            foreach (string brand in cars)
            {
                //if the backup list contains the current item from the main list, display a message
                //saying it has appeared before
                if(carsCopy.Contains(brand))
                {
                    Console.WriteLine(brand + "has appeared before");
                }
                //otherwise, display a message saying it has not appeared before
                else
                {
                    Console.WriteLine(brand + "has not appeared before");
                }
                //adds the current item from the main list to the backup list
                carsCopy.Add(brand);
                Console.WriteLine(brand);
            }
            Console.ReadLine();
        }
    }
}
