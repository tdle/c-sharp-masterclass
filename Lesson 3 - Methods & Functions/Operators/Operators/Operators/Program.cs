using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            //{0} will replace with the first variable it comes across
            num3 = num1;
            Console.WriteLine("num3 is {0}", num3);


            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            //++ moves int value up by 2
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);

            //pre increment operators
            Console.WriteLine("num is {0}", ++num);

            //decrement operators
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);

            //pre increment operators
            Console.WriteLine("num is {0}", --num);

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            //Modular Operator
            //% Divided and returns the remainder
            result = num1 % num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            //equality operators
            bool isEqual;
            isEqual = num1 == num2;

            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            //conditonal operators
            //Takes the value from both bool, and if they share the same bool output, will return true
            bool isLowerAndSunny;

            //Condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isEqual);

            //or operator
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isEqual);

            Console.ReadKey();
        }
    }
}
