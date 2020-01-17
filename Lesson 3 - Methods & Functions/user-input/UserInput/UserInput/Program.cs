using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lesson 3.32
            //User Input

            Calculate();
            Console.Read();

            //Challenege - Create a tool that adds numbers based on user input
        }

        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;

            Console.WriteLine(result);
        }z
    }
}
