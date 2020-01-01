using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson 2.16
            int num1 = 13;
            int num2 = 15;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;


            float f1 = 3.5f;
            float f2 = 1.337f;
            float sumF = f1 + f2;

            //Use casting
            //int divDandI = d1 / num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sumF);
            Console.ReadLine();

            //Lesson 2.17
            //Datatype String and Some of it's Method
            //String is a class not a data type
            //string is a datatype (lowercase s)

            string myname = "Tom";
            string message = "My Name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
            Console.ReadLine();

            //Leson 2.18
            //Naming Conventions and Coding Standards

            //Class names like ClientActivity should be written in pascal casing
            //Different from camel casing where the first character is of lower case

            //use camel casing for Method Arguments like firstNumber
            //user camel casing for local variables like itemCount
            //do not abbreviate variable names e.g. userControl instead of usrCtr

            //dont user numbers at the start of variable names
            //try to avoid underscore
            //exceptions are underscores at the beginning

            //Correct

            string myname1;
            int lastNum;
            bool isSaved;

            //Avoid
            //String myName;
            //Int32 lastNum;
            //Boolean isSaved;

            //For classes try to use nouns
            //For methods, these are usually actions, so user verbs
            //Go to www.dofactory.com/reference/csharp-coding-standards for more info

            //Lesson 2.19
            //Implicit and Explicit Conversion

            double myDouble = 13.37;
            int myInt;

            //cast double to int
            //Explicit Conversion
            myInt = (int)myDouble;

            Console.WriteLine(myInt);
            Console.Read();

            //implicit conversion
            int num = 12390345;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //Type Conversion
            string myString = myDouble.ToString(); //"13.37" - Will convert but will convert with quotation marks
            string challengeString = myFloat.ToString();

            Console.WriteLine("I have converted " + myFloat + " to a string = " + challengeString);

            bool sunIsShining = false;
            sunIsShining.ToString();

            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);

            //Lesson 2.20
            //Parsing a String to an Integer

            string myString2 = "15";
            string mySecondString = "13";

            int num3 = Int32.Parse(myString2);
            int num4 = Int32.Parse(mySecondString);
            int resultInt = num3 + num4;

            string result = myString2 + mySecondString;

            Console.WriteLine(result);
            Console.WriteLine(resultInt);
            Console.ReadLine();

            //Lesson 2.21
            //Challenge - Datatypes and Variables

            byte myByte = 1;
            sbyte mySbyte = 2;
            int myInt5 = 3;
            short myShort = 4;
            long myLong = 5;
            float myFloat1 = 6.1f;
            double myDouble1 = 7.1;
            char myChar = 'A';
            bool myBool1 = true;
            string myString3 = "I control text";
            string wholeNumber = "8";

            int challengeResult = Int32.Parse(wholeNumber);
            Console.WriteLine(challengeResult);

            Console.WriteLine(myByte);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myInt5);
            Console.WriteLine(myShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myFloat1);
            Console.WriteLine(myDouble1);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool1);
            Console.WriteLine(myString3);

            //Lesson 2.22
            //Constants
            //Constants are immutable values which are known at compile time and do not change for the life of the program.

            //constants are fields
            const double PI = 3.141592653659;
            const int weeks = 52, months = 12;

            //Challenge
            //Create a constant of type string with your birthday as it's value

            const string birthday = "21.08.1992";
            Console.WriteLine("My Birthday is always going to be {0}", birthday);
            Console.ReadLine();
        }
    }
}
