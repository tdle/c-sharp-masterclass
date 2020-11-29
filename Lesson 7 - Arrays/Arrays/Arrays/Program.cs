using System;
using System.Net.Http.Headers;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //define how many values you want to add to this array
            int[] grades = new int[5];

            //adding grades to the array
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 3;
            grades[3] = 56;
            grades[4] = 12;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            Console.ReadKey();

            string input = Console.ReadLine();

            //assing value to arry grades at index 0
            //grades[0] = int.Parse(input);

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            Console.ReadKey();

            //Another way to initalise an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //third way of initialising an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            Console.ReadKey();


            //For Loop
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
            }


            /*Challenge
             * Create an array with 5 of your best friends
             * Create a foreach loop which greats all of them
             */

            //int friendCounter = 0;
            string[] friends = { "Leanne", "Demi", "John", "B", "Corey" };
            foreach (string f in friends)
            {
                Console.WriteLine("Hello {0}, it's nice to meet you!", f);
            }

            //declare 2D array
            string[,] matrix;

            //declare 3D array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9}  // row 2
            };

            Console.WriteLine("Central Value is {0}", array2D[1, 1]);

            string[,] array2DString = new string[3, 2]
                {
                    {"one", "two" },
                    {"three", "four" },
                    {"five", "six" }
                };

            //challenge - Turn the number four value into chicken

            array2DString[1, 1] = "chicken";
            Console.WriteLine("The value for {0}", array2DString[1, 1]);

            //get the numner of dimensions for the array
            int dimensions = array2DString.Rank;


            //Challenge
            // Try to access 7th value

            Console.WriteLine("7th Value is {0}", array2D[2, 0]);
            Console.ReadKey();
        }

            class Animal // base class (parent)
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal //Derived Class (child)
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }
    }
}
