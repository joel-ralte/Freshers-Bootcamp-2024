using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.NumberAdderLib
{
    internal class DelimiterInputAdder
    {
        public static int AddDelimiterInputNumbers(string input)
        {
            long sum = 0;
            var delimiters = new char[] { ',', '\n' };
            var numbers = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var number in numbers)
            {
                sum += long.Parse(number);
                if (sum > int.MaxValue) { return int.MaxValue; }
            }
            return (int)sum;
        }
    }
}
