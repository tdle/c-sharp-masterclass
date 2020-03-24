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

            Console.Read();
        }
    }
}
