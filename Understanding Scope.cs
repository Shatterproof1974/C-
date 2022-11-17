using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        //a variable is only valid within the code it is written and is disposed off when finished.
        private static string k = "";//private field is a available to all members of the class it needs to be added to the loop

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)//this statement genrates a loop of ten times when run
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
               // Console.WriteLine(l);
            }
            //Console.WriteLine(i); - i is no longer available and has been defined so will bring up a error if run
            Console.WriteLine("Outside of the for: " + j); // when run this brings up the value 9 because it brings up the value of j
            Console.WriteLine("Outside of the for: " + k); // when this runs it displaya second 9
            HelperMethod(); // this briungs up Value k from HelperMethod(): 9
            Console.ReadLine();//shows the results when the script is run
        }
        static void HelperMethod()//
        {
            Console.WriteLine("Value k from the HelperMethod(): " + k);
        }
    }
}
