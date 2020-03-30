using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int counter = 0; counter < 10; counter++)
            {
                if(counter %2 == 3)
                {
                    Console.WriteLine("We skip number 3!");
                    continue;

                    //break - will get out the loop, the code below will then be executed
                }
                Console.WriteLine(counter);
                Console.Read();
            }
        }
    }
}
