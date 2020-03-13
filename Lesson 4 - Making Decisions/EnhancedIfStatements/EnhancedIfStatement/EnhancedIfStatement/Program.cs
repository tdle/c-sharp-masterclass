using System;

namespace EnhancedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second expression
            // condition has to be either true or false
            // The conditional operator is right - associative
            // The expression a ? b: c? d : e 
            // is evaulated as a ? b : c( ? d : e),
            // not as (a? b : c) ? d: e,
            // The conditional operator cannot be overloaded

            //temperature starts at -5 degrees
            int temperature = -5;
            string stateOfMatter;

            Console.WriteLine("Temperature is currently set at " + temperature + " degrees");

            if (temperature < 0)
                stateOfMatter = "liquid";
            else
                stateOfMatter = "solid";

            //state of matter will be solid
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.WriteLine("|---------------------->");
            Console.ReadLine();

            //temperature increases by 30 degrees
            Console.WriteLine("Temperature has now increased by 30 degrees");
            temperature += 30;

            //temperature should now be set to 25 degrees
            //state of matter will be liquid
            Console.WriteLine("Tempeature is currently set at " + temperature + " degrees");
            Console.WriteLine("|---------------------->");
            Console.ReadLine();

            //enhanced if statement
            Console.WriteLine("Temperature is currently set at " + temperature + " degrees");

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.WriteLine("|---------------------->");
            Console.ReadLine();

            //temperature increases by 100 degrees
            Console.WriteLine("Temperature has no icreased by 100 degrees");
            temperature += 100;

            //temperature should now be 125 degreees
            //state of matter will be liquid
            Console.WriteLine("Tempeature is currently set at " + temperature + " degrees");
            Console.WriteLine("|---------------------->");
            Console.ReadLine();

            //add gas state of matter to the options
            //if temperature is higher than 100 degress

            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "liquid"; 

            Console.WriteLine("Is the state of matter a gas or liquid?");
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.WriteLine("|---------------------->");
            Console.ReadLine();

            Console.WriteLine("The final temperature is " + temperature + " degrees");
            Console.ReadLine();
        }
    }
}
