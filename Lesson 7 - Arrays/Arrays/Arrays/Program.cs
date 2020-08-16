using System;
using System.Net.Http.Headers;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            int[] grades = new int[5];
=======
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
            grades[0] = int.Parse(input);

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

            for(int j = 0; j < 10; j++)
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
            string[] friends = {"Leanne", "Demi", "John", "B", "Corey" };
            foreach(string f in friends)
            {
                Console.WriteLine("Hello {0}, it's nice to meet you!", f);
            }

>>>>>>> 23b1f11487e3403477a53672b1f53736492174df
        }
    }
}
