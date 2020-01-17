using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the Method WriteSomething

            WriteSomething();
            WriteSomethingSpecific("I am an argument and I am called from a Method");
            Console.ReadLine();

            //You can call your method from within a method
            Console.WriteLine(Add1(Add1(1, 2), Add1(3, 4)));
            Console.WriteLine(Add1(15, 31));

            Console.WriteLine(Multiply(10, 30));

            Console.WriteLine(Divide(10, 30));

            //A method is a code block that contains a series of statements.
            // A program causes the statements to be executed by calling the Method, and specifying any required Method Arguments.
            //In C#, every executed instruction is performed in context of a Method.
            //The Main method is the entry point for every C# application and it is called by the common language runtime CLR when the program is started

            //Sytax for a Method
            //Access Specifier> <Return Type> <Method Name>(parameter List)
            //{
            //      Method
            //}

        }

        //Example
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        //Lesson 3.28
        //void Methods

        //Access Modifier (static) return type method name (parameter 1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a Method");
            Console.Read();
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        //Lesson 3.29
        //Methods with Return value and Parameters
        public static int Add1(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
