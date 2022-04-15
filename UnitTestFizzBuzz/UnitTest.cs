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
        public void Divisible_By_Three()
        {

            // arrange
            FizzBuzz fb = new FizzBuzz();

            // act
            bool _actual = fb.DivideByThree(1);
            bool _expected = false;

            // assert
            Assert.AreEqual(_expected, _actual);

        }


        [TestMethod]
        public void Divisible_by_Five()
        {
            // arrange
            FizzBuzz fb = new FizzBuzz();

            // act
            bool _actual = fb.DivideByFive(10);
            bool _expected = true;

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void Divible_by_Five_and_Three()
        {

            // arrange
            FizzBuzz fb = new FizzBuzz();

            // act
            bool _actual = fb.DivideByThreeAndFive(15);
            bool _expected = true;

            bool _actual3 = fb.DivideByThree(15);
            bool _expected3 = true;

            bool _actual5 = fb.DivideByFive(15);
            bool _expected5 = true;

            // assert
            Assert.AreEqual(_expected, _actual);
            Assert.AreEqual(_actual3, _expected3);
            Assert.AreEqual(_actual5, _expected5);

        }

    }


   
}
