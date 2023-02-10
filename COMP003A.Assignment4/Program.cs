/* 
 *  Author: Matthew Alvarez
 *  Course: COMP-003A
 *  Purpose: Assignment 4 - Looping Structures
 */

using System.Diagnostics.Tracing;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 4";

            /* for-loop section (Right Triangle) */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("".PadRight(43,'-'));
            Console.WriteLine("for-loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(43, '-'));
            Console.Write("Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            string output = "#";
            
            for(int i = 0; i < limit; i++) 
            { 
                Console.WriteLine(output);
                output += "#";
            }
            Console.WriteLine("\n");

            /* for-each section (Friends) */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("".PadRight(40, '-'));
            Console.WriteLine("for-each section");
            Console.WriteLine("Output every character name from Friends");
            Console.WriteLine("".PadRight(40, '-'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach(var item in friends)
            {
                Console.WriteLine($"Current Friend: {item}");
            }
            Console.WriteLine("\n");

            /* Do - While Loop Section (Counting by 5s) */
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("".PadRight(17, '-'));
            Console.WriteLine("do-while section");
            Console.WriteLine("Output Count by 5");
            Console.WriteLine("".PadRight(17, '-'));

            int counter = 0;

            do
            {
                Console.WriteLine("Counter: " + counter);
                counter += 5;
            } while (counter <= 50);
            Console.WriteLine("\n");

            /* While Loop Section (FooBar) */
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("".PadRight(13, '-'));
            Console.WriteLine("while section");
            Console.WriteLine("Output FooBar");
            Console.WriteLine("".PadRight(13, '-'));
            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, 'X'));
            Console.WriteLine("\t\tEND OF PROGRAM");
            Console.WriteLine("".PadRight(50, 'X'));
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}