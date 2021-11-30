using ClassLibraryStandard;
using System;
using System.Collections.Generic;

namespace ConsoleAppCore
{
    class Program
    {      
        static void Main(string[] args)
        {
            const int maxlength = 100;
            string[] _results = new string[maxlength];
            FizzBuzz fb = new FizzBuzz();

            int _index = 0;
            for (int i = 1; i <= maxlength; i++)
            {
                if (fb.DivideByThreeAndFive(i))
                {
                    _results[_index] = "fizzbuzz";
                }
                else if (fb.DivideByFive(i))
                {
                    _results[_index] = "buzz";

                }
                else if (fb.DivideByThree(i))
                {

                    _results[_index] = "fizz";
                }
                else 
                {
                    _results[_index] = i.ToString();
                }
                _index++;
            }

            Printer p = new Printer();
            p.Print(_results);

            //FizzBuzzPrint _print = new FizzBuzzPrint();

            //Console.WriteLine("Enter a max number to check: ");
            //int value;
            //bool _isValueNumber = int.TryParse(Console.ReadLine(), out value);

            //if (_isValueNumber)
            //{
            //    for (int i = 1; i <= value; i++)
            //    {
            //        Console.WriteLine("Current number is {0}, FizzBuzz check is {1})", i, _print.Check(i));
            //    }
            //}
            //else {
            //    Console.WriteLine("Input was not a number!!!");
            //}


            Console.ReadKey();
        }
    }
}
