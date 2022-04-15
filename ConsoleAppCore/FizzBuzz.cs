using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCore
{
    public class FizzBuzz
    {

        public bool DivideByThree(int number)
        {

            if (number % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DivideByFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DivideByThreeAndFive(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
