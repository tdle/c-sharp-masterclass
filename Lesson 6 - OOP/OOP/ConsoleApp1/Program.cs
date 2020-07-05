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
            Human john = new Human("John", "Wick", "Brown", 55);
            john.IntroduceMyself();

            //second object for challenge
            Human harry = new Human("Harry", "Potter", "Blue", 18);
            harry.IntroduceMyself();

            //Third object using default constructor
            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            //second object for challenge
            Human ron = new Human("Ronald", "Weasley", "Blue");
            harry.IntroduceMyself();

            Human hermione = new Human("Hermione");
            hermione.IntroduceMyself();

            Human neville = new Human("Neville", "Longbottom");
            neville.IntroduceMyself();

            Human draco = new Human("Draco", "Malfoy", 19);
            draco.IntroduceMyself();

            Console.ReadKey();
           
        }
    }
}
