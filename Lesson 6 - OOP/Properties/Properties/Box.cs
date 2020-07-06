using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {

        /*
         * We are encapsulating data, and restricting access to length
         * We use the setters and getters in order to still change the value without accessing the member variable directly
         * */

        //member variables
        //everyone who has access to this class, can change the values of these member variables
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        //using property without the use of a member variable

        public int Width { get; set; }

        //property
        //use property with a capital at the start
        //we are still setting and getting length, but our gateway is now via the property
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                //whatever we set the value of heigh too, in program.cs, this will become the value
                if(value < 0)
                {
                    height = -value;
                } else
                {
                    height = value;
                }
            }
        }

        //Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        //Setter Method
        public void SetLength(int length)
        {
            //using the this. it will target the member variable listed above
            //the length it is equal too, is set to the string length
            //By throwing an exeption we can actively set what the member variable should be set too
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }

            this.length = length;
        }

        //getter method
        //type needs to be the same as the type you want to return e.g. int
        public int GetLength()
        {
            //could use just length, but by using this.length you are perfectly clear that you care returning the member variable
            return this.length;
        }

        //getter method for volume
        //can this type of getter method so we aren't pulling the value from the member variable
        public int GetVolume()
        {
            return this.length * this.height * Width;
        }

        //method
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2}, so the volume is {3}", length, height, Width, volume = length*height*Width);
        }

        //Challenge
        // Create a property for volume#

        //public int Volume { get; set; }

        public int Volume
        {
            get
            {
                return this.length * this.height * Width;
            }
        }

        //Challenge 2
        /* Create a read only property "FrontSurface" which calculates the front surface based on height and length
         */

        public int FrontSurface
        {
            get { return height * length; }
        }
    }
}
