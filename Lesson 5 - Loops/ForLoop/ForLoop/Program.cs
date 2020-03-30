using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine("For Loop has complete");

            //do-while loop
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);

            Console.WriteLine("Thanks, that was enough! " + wholeText);

            //while loop

            int whileCounter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else." +
                    " + enter if you want to finishing counting");
                enteredText = Console.ReadLine();

                whileCounter++;
                Console.WriteLine("Current people count is {0}", whileCounter);
                
                //++ operator will increase the count by 1 until conditions are met
                //{0}, will be replaced with specified variable, in the above case this will be the string whileCounter
            }

            Console.WriteLine("{0} people are inside the bus, press enter to close the program", whileCounter);
            Console.Read();
        }
    }
}
