using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeiss.NumberAdderLib
{
    internal class MultiCharAdder
    {
        public static int AddMultipleCharNumbers(string input)
        {
            if (input.Contains('-'))
                throw new ArgumentException("Negative values are not allowed.");

            if (input.Contains(","))
            { 
                return DelimiterInputAdder.AddDelimiterInputNumbers(input);
            }
            return int.Parse(input);
        }
    }
}
