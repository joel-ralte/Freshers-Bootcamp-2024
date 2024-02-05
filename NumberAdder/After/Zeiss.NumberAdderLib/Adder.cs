using System;

namespace Zeiss.NumberAdderLib
{
    public class Adder
    {
        public static int AddNumbers(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            if (input.Length == 1)
                return input[0] - '0';

            if (input[0] == '-')
                throw new ArgumentException("Negative values are not allowed.");

            if (input.Contains(",") || input.Contains("\n"))
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

            return int.Parse(input);
        }
    }
}