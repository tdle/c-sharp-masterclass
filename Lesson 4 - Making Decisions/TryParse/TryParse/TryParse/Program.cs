using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement - what to do if condition is met
            //else statement - what to do if non of the conditions is met
            //else if statement - what to do if condition two is met

            Console.WriteLine("Whats the temperature like this morning?");

            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if(userEnteredANumber)
            {
                numTemp = number;
            } else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number. 0 set as temperature");
            }

            if(numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            } else if(numTemp == 20)
            {
                Console.WriteLine("Pants and a pull over should be fine");
            } else if(numTemp > 30) 
            {
                Console.WriteLine("It's super hot");
            } else
            {
                Console.WriteLine("Shorts are enough for today!");
            }

            Console.Read();

            //TryParse - By using the TryParse() method you can convert a string like '128' into a numeric data type like an integer
            //TryParse - Often gets used when the user submits input

            string numberAsString = "128";
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            //The returned boolean is true when parsing was successful

            if(success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing Unsuccessful");
            }

            //Parsing Fails

        }
    }
}
