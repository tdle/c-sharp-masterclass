using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MembersC
{
    class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        //member - public field
        public int age;

        //member property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job titles is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}", salary);
        }

        //member Constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine( "Object Created");
        }

        //member - finalizer - destructor
        //class can have only one destructor
        //cannot be inhertied or overloaded or called
        ~Members()
        {
            //cleaup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }
    }
}
