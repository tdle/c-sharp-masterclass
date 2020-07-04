using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is how you create an object of a class
            //Box is the name of the class we made before
            Box box = new Box(3,4,5);


            Console.WriteLine("Box's Width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's Width is " + box.Width);
            Console.WriteLine("Box's Volume is " + box.GetVolume());
            box.DisplayInfo();

            //Summary
            /*Created a number of member variables
             * made them private so no other classes could access them
             * set them up with setters and getters
             * */
        }
    }
}
