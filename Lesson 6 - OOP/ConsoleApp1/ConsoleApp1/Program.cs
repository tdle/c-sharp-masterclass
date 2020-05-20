using System;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {

            /*A class is a blueprint of an object
            It has actions/ abilities - so called member functions or methods
            and it has properities - so called member variables*/


            //Create an object of my class
            //an instance of human

            Human denis = new Human();

            //Access public variable from outside class, and even change it
            denis.firstName = "Denis";

            //call methods the class
            denis.IntroduceMyself();

            Console.ReadKey();
            

        }
    }
}
