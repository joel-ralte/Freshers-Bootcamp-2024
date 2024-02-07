using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Zeiss.NumberAdderLib;

namespace Zeiss.NumberAdderLib.Test
{
    public class Test1Data : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "", 0 };
            yield return new object[] { "0", 0 };
            yield return new object[] { "1", 1 };
            yield return new object[] { "1,2", 3 };
            yield return new object[] { "12,34", 46 };
            yield return new object[] { "99999999999,99999999999", int.MaxValue };
            yield return new object[] { "1\n2,3", 6 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class NumberAdderAddOperationTestSuite
    {
        [Theory]
        [ClassData(typeof(Test1Data))]
        public void AddNumbersTest(string input, int expectedResult)
        {
            int actualResult = NumberAdderLib.StringAdder.AddNumbers(input);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
