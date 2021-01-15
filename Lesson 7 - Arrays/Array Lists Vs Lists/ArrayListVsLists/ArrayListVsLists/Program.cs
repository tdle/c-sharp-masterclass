﻿using System;
using System.Collections.Generic;

namespace ArrayListVsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //immutable - limited to one type
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };

            list.Add(0);
            list.Add(32);
            list.Sort();

            //index of 2
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            //lambada expression
            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);
            list.ForEach(i => Console.WriteLine(i));

            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("3");
            arrayList.Add(new number { n = 4 });

            foreach(Object o in arrayList)
            {
                Console.WriteLine(o);
            }

            Console.ReadLine();
        }

        class number
        {
            public int n { get; set; }

            public override string ToString()
            {
                return n.ToString();
            }
        }
    }
}
