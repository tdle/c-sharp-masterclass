using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    //this class is a blueprint for a datatype
    class Human
    {
        //member variable
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }
        
        // parameterized constructor for just using the firstName
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //parameterized constructor for firstName and lastName
        public Human (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //Parameterized constructor
        /* You could use multiple constructors for different scenarios for your application
         * Each constructor will handle different code scenarios e.g. just firstName if there is no other info etc 
         * */

        public Human(string firstName, string lastName, string eyeColour)
        {
            //can use the 'this' keyword, takes the last string of firstName, lastName
            //last name takes the lastName string from member variable
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        public Human(string firstName, string lastName, int age)
        {
            //can use the 'this' keyword, takes the last string of firstName, lastName
            //last name takes the lastName string from member variable
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // parameterized constructor
        // public is the access modifier - we use public so we can access it
        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            //can use the 'this' keyword, takes the last string of firstName, lastName
            //last name takes the lastName string from member variable
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }

        //create a method
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColour != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eyes and I am {3} years old", firstName, lastName, eyeColour, age);
            else if(age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My age is {2}", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName);
            }
        }

        // Challenge 1
        /* Create a public variable lastName of type string - DONE
         * Change the IntroduceMyself method, so it tells me the whole name - DONE
         * Create two objects with full information about themselves - firstName and lastName - put this in the program.cs -DONE

        //Challenge 2
         * Add two more member variables to "Human". Eyecolour and Age - DONE
         * Adjust the constructor, so it requires all of the four values to be used, when creating an object of Human - DONE
         * Create objects of type Human - DONE
         */
         
        //Challenge 3
        /* Create a constructor for just firstName and lastName - DONE
         * Create a constructor for just firstName - DONE
         * Adjust console output accordingly
         */
    }
}
