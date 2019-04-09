/*
 * "using" just means that we are importing code that other people ahve written.
 * In this case, we are using the standard code ("libraries") made by Microsoft
 * as an official part of C#.
 */
using System;
using System.Collections.Generic;

/*
 * A namespace is a bundle of code (specifically classes) that you write.
 */
namespace CSharpExamples
{
    /*
     * A class is the basic (and smallest) runnable unit of code. Think morphemes.
     */
    class Program
    {
        /*
         * A method is a peice of code that "does something"
         * Programs always start at the Main mehtod.
         */
        static void Main(string[] args)
        {
            /*
             * Goals:
             *      Understand why this code works
             *      Be able to modify this code to do other things
             *      As a challenge, be able to write similar code from scratch!
             */

            //Here is the code!
            Console.WriteLine("Enter a phrase (q to quit)");

            bool keepGoing = true;

            while (keepGoing)
            {
                string word = Console.ReadLine();

                if (word == "q")
                {
                    keepGoing = false;
                }
                else
                {
                    int length = word.Length;
                    Console.WriteLine("The phrase '" + word + "' has " + length + " characters");
                }
            }
            Console.WriteLine("You quit! Press enter to end the program.");
            Console.Read();

            MathStuff(5, 3);
            MathStuff(1, 3);
            MathStuff(0, 0);
            Console.Read();
        }

        /*
         * If x is greater than y, add
         * If x is less then y, subtract y from x
         * If x equals y, divide x by y
         * 
         * Print your answer to the console
         */
        static void MathStuff(int x, int y)
        {
            bool greater = (x > y);
            if (greater)
            {
                Console.WriteLine(x + y);
            }

            bool less = (x < y);
            if (less)
            {
                Console.WriteLine(x - y);
            }
            bool eq = (x == y);
            if (eq)
            {
                Console.WriteLine(x / y);
            }
        }

        static void Func()
        {
            int x = 5;
            int y = 6;
            int add = x + y;

            bool eq = (x == y);
            bool greater = (x > y);
            bool lessOrEqual = (x <= y);

            string strX = "this is" + " text";
        }
    }
}