using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string friend1 = "Tom";
            string friend2 = "Will";
            string friend3 = "Blake";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();

        }

        public static void GreetFriend(string friendsName)
        {
            Console.WriteLine("Hi " + friendsName + ", my friend!");
        }
    }
}
