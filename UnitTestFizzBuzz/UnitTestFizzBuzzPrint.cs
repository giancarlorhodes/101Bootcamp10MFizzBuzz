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
    }
}
