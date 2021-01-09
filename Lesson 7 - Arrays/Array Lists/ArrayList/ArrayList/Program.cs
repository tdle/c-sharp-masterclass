using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an Array List with undefined amount of objects
            ArrayList myArrayList = new ArrayList();
            //Declare an Array List with defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            
            //Removal of a specific value from the Array List
            myArrayList.Remove(13);

            //Delete element at a specific postion
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum += (double)obj;
                } else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
