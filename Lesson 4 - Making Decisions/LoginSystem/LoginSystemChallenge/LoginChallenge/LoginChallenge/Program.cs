using System;

namespace LoginChallenge
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();

            Console.Read();
        }

        public static void Register()
            //Make method static so that we can call the method in the main method
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();

            Console.WriteLine("Registration completed!");
            Console.WriteLine("<---------------------------------------------------->");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failed, one or more of your credentials is incorrect. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login Failed, one or more of your credentials is incorrect. Restart Program");
            }

        }
    }
}