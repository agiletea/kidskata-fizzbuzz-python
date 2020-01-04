/************************************************************************************************************/
/* Helper Methods - DO NOT make any changes inside here, else you could break your program!                 */
/* These methods are designed to make it easier to do some of the basics in the code without adding too     */
/* much bloat and confusion to the task at hand                                                             */
/************************************************************************************************************/
using System;

namespace FizzBuzz
{
    partial class Program
    {
        static int InputNumber(string text)
        {
            Console.WriteLine(text);
            var args = Console.ReadLine();

            if (!int.TryParse(args, out var number))
            {
                Console.WriteLine($"Oops! {args} doesn't look like a number. Try again!");
                InputNumber(text);
            }

            return number;
        }

        static void PrintNumber(int number)
        {
            Console.Write(number.ToString());
        }

        static void PrintWord(string word)
        {
            Console.Write(word);
        }

        static void PrintSpace()
        {
            Console.Write(" ");
        }
    }
}
