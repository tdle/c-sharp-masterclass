using System;

namespace TryAndCatchC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number?");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Cannot divide by zero");
            }

            try
            {
                int userInputAsInput = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format Exception, please enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty (null)");
            }
            finally
            {
                Console.WriteLine("This is called regardless of whether the errors are called or not");
            }

            Console.ReadKey();
        }
    }
}
