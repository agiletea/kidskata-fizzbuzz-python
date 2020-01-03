using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz!");

            int x = InputNumber("Please enter a start number and then press the 'Enter' key: ");
            int y = InputNumber("Please enter an end number and then press the 'Enter' key: ");
            
            PrintNumberRange(x, y);

            Console.WriteLine("Program has completed. Press any key to exit");
            Console.ReadKey();
        }

        static void PrintNumberRange(int startNumber, int endNumber)
        {
            // START here!            
        }

#region Helper Methods - DO NOT make any changes inside here, else you could break your program!
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
#endregion 
    
}
