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

        //create a method
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0}", firstName);
        }

    }
}
