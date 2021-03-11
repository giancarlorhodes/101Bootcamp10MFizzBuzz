using ClassLibraryStandard;
using System;

namespace ConsoleAppCore
{
    class Program
    {      
        static void Main(string[] args)
        {
            FizzBuzzPrint _print = new FizzBuzzPrint();

            Console.WriteLine("Enter a max number to check: ");
            int value;
            bool _isValueNumber = int.TryParse(Console.ReadLine(), out value);

            if (_isValueNumber)
            {
                for (int i = 1; i <= value; i++)
                {
                    Console.WriteLine("Current number is {0}, FizzBuzz check is {1})", i, _print.Check(i));
                }
            }
            else {
                Console.WriteLine("Input was not a number!!!");
            }
            Console.ReadKey();
        }
    }
}
