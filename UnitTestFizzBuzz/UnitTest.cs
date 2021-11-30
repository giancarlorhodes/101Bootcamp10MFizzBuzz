using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCore;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest
    {


        [TestMethod]
        public void Test_For_Divisible_By_Three()
        {

            // arrange
            FizzBuzz obj = new FizzBuzz();

            // act
            bool _actual = obj.DivideByThree(1);
            bool _expected = false;

            // assert
            Assert.AreEqual(_expected, _actual);

        }

    }


   
}
