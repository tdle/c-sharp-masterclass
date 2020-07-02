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

            //Challenge Object
            Human john = new Human("John", "Wick");

            john.IntroduceMyself();

            //second object for challenge
            Human harry = new Human("Harry", "Potter");

            harry.IntroduceMyself();

            Console.ReadKey();
           
        }
    }
}
