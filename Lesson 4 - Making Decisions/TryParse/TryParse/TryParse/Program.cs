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
            int numTemp = int.Parse(temperature);

            if(numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            }

            if(numTemp == 10)
            {
                Console.WriteLine("Pants and a pull over should be fine");
            }

            if(numTemp > 10)
            {
                Console.WriteLine("Shorts are enough for today");
            }

            Console.Read();

        }
    }
}
