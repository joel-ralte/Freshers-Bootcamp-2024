using System;

namespace Zeiss.NumberAdderLib
{
    public class StringAdder
    {
        public static int AddNumbers(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            if (input.Length > 1)
                return MultiCharAdder.AddMultipleCharNumbers(input);

            return int.Parse(input);
        }
    }
}