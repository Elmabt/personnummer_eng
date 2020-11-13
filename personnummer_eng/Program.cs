using System;
using System.ComponentModel;

namespace personnummer_eng
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program will ask for a 12 digit social security number
            Console.WriteLine("enter a 12-digit social security number: ");
            var pn = Console.ReadLine();

            //this function should check that it is a 12 digit number and not an 11 or 13 digit number
            // || = The result of x || y is true if either x or y is evaluated to be true. Otherwise the result is false
            if (pn.Length < 12 || pn.Length > 12)
            {
                //if the social security number is not 12 digits, "opps the social security number must have 12 digits"
                Console.WriteLine(" opps the social security number must have 12 digits");
                Console.ReadLine();
                return;
            }
            //this function is to see if the date is correct, ie the first 8 digits
            var date = pn.Substring(0, 8);
            var datea = DateTime.TryParse(date.Insert(4, "-").Insert(7, "-"), out var datec);
            //if the date is incorrect
            if (!datea)
            {
                //if the date is wrong this will come up "the date is wrong"
                Console.WriteLine("the date is incorrect");
                Console.ReadLine();
                return;
            }
            //the function to see if the year is between 1753 and 2020
            if (datec.Year < 1753 || datec.Year > 2020)
            {
                Console.WriteLine("the year had to be in between 1753-2020");
                var Year = Console.ReadLine();
                return;
            }
            // This feature will be for those whether it is a woman or a man.
            String siffras = pn.Substring(8, 3);
            int siffrascon = int.Parse(siffras);
            //if it's an odd number, it's a woman
            if (siffrascon % 2 == 0)
            {
                Console.WriteLine("its a woman");
            }
            //if it's not an odd number, it's one
            else
            {
                Console.WriteLine("its a male");
            }
            
               
            
            //when the programmer has completed, this message should be up
            Console.WriteLine("the social security number is the correct press of a random button to exit: D");


        }
    }
}

