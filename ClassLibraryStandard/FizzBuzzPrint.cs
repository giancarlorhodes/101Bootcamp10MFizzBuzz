using System;

namespace ClassLibraryStandard
{
    public class FizzBuzzPrint
    {

        public string Check(int inNumber) 
        {
            if (this.FizzBuzz(inNumber))
            {
                return "FizzBuzz";
            }
            else if (this.Fizz(inNumber))
            {
                return "Fizz";
            }
            else if (this.Buzz(inNumber))
            {
                return "Buzz";
            }
            else return "Nothing";
        }



        private bool Fizz(int inNumber) 
        {
            return inNumber % 3 == 0 ? true : false;        
        }

        private bool Buzz(int inNumber)
        {
            return inNumber % 5 == 0 ? true : false;
        }

        private bool FizzBuzz(int inNumber)
        {
            return this.Fizz(inNumber) && this.Buzz(inNumber);
        }


    }
}
