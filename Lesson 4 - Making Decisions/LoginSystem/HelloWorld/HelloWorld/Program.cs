using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Please enter your username!");

            userName = Console.ReadLine();

            //compare integers you use ==, for strings use .equals

            //Nested if statements
            //if statement within an if statement
            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user!");
                Console.WriteLine("Hi there, " + userName);
                Console.WriteLine("Hi there, Admin");
            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("Welcome registered admin!");
            }

            Console.ReadLine();
        }

    }
}
