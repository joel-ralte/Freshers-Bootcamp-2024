using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zeiss.NumberAdderLib;

namespace Zeiss.NumberAdderLib.Test
{
    [TestClass]
    public class NumberAdderAddOperationTestSuite
    {
        [TestMethod]
        public void ForEmptyStringZeroIsExpected()
        {
            string input = "";
            int expectedResult = 0;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForZeroStringZeroIsExpected()
        {
            string input = "0";
            int expectedResult = 0;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForOneStringOneisExpected()
        {
            string input = "1";
            int expectedResult = 1;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForTwoDigitStringSumIsExpected()
        {
            string input = "12";
            int expectedResult = 3;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForTwoDigitStringWithCommaSumIsExpected()
        {
            string input = "1,2";
            int expectedResult = 3;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForThreeDigitStringSumOfEachDigitIsExpected()
        {
            string input = "123";
            int expectedResult = 6;

            int actualResult = NumberAdderLib.Adder.AddNumbers(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ForNegativeStringErrorIsExpected()
        {
            string input = "-123";
            string expectedErrorMessage = "Negative values are not allowed.";

            try
            {
                int actualResult = NumberAdderLib.Adder.AddNumbers(input);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(expectedErrorMessage, ex.Message);
            }
        }
    }
}
