using ClassLibraryStandard;
using System;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzPrint _print = new FizzBuzzPrint();

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("Current number is {0}, FizzBuzz check is {1})", i, _print.Check(i));
            }

            Console.ReadKey();
        }
    }
}
