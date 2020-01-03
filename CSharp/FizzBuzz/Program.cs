using System;

namespace FizzBuzz
{
    partial class Program
    {
        /// <summary>
        /// The Main method is the starting point of your program and is the first code to be run
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Welcome to FizzBuzz!");

            int x = 1;
            int y = 20;

            // we now 'call' the PrintNumberRange method, passing in x as the startNumber parameter
            // and 'y' as the endNumber parameter.
            PrintNumberRange(x, y);

            Console.WriteLine("Program has completed. Press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// This is the method in which you will complete your exercise
        /// </summary>
        /// <param name="startNumber">This is that start number you will pass in</param>
        /// <param name="endNumber">This is the end number you will pass in</param>
        static void PrintNumberRange(int startNumber, int endNumber)
        {
            // START here!            
        }
    }
}
