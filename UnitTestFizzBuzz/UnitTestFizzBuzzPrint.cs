using ClassLibraryStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTestFizzBuzzPrint
    {
        FizzBuzzPrint _print;

        public UnitTestFizzBuzzPrint() 
        {
            _print = new FizzBuzzPrint();             
        }

        // divides by 3 perfectly case
        [TestMethod]
        public void Three_Is_Fizz_True()
        {
            // arrange
            string _IsThisFizz;

            // act
            _IsThisFizz = _print.Check(3);

            // assert
            Assert.IsTrue(_IsThisFizz == "Fizz");
        }


        // divides by 5 perfectly
        [TestMethod]
        public void Five_Is_Buzz_True()
        {
            // arrange
            string _IsThisBuzz;

            // act
            _IsThisBuzz = _print.Check(5);

            // assert
            Assert.IsTrue(_IsThisBuzz == "Buzz");
        }


        // divides by 5 perfectly
        [TestMethod]
        public void Eleven_Is_False()
        {
            // arrange
            string _value;

            // act
            _value = _print.Check(11);

            // assert
            Assert.IsFalse(_value == "Fizz" || _value == "Buzz");
            Assert.IsTrue(_value == "Nothing");
        }
    }
}
