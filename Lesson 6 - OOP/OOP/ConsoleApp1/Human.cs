using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    //this class is a blueprint for a datatype
    class Human
    {
        //member variable
        public string firstName;
        public string lastName;

        // constructor
        // public is the access modifier - we use public so we can access it
        public Human(string firstName, string lastName)
        {
            //can use the 'this' keyword, takes the last string of firstName, lastName
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //create a method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }

        // Challenege
        // Create a public variable lastName of type string - DONE
        // Change the IntroduceMyself method, so it tells me the whole name - DONE
        // Create two objects with full information about themselves - firstName and lastName - put this in the program.cs
    }
}
