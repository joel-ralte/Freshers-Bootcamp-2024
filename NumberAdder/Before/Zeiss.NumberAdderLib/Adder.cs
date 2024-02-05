using System;

public class Adder
{
    public static int AddNumbers(string input)
    {
        // Handle empty input
        if (string.IsNullOrEmpty(input))
            return 0;

        // Handle single-digit input
        if (input.Length == 1 && Char.IsDigit(input[0]))
            return input[0] - '0';

        // Handle comma-separated input
        if (input.Contains(","))
        {
            int sum = 0;
            var numbers = input.Split(',');
            foreach (var number in numbers)
            {
                sum += ParseAndValidate(number);
            }
            return sum;
        }

        // Handle general case
        return ParseAndValidate(input);
    }

    private static int ParseAndValidate(string input)
    {
        if (!int.TryParse(input, out int number))
            throw new ArgumentException("Invalid input format.");

        if (number < 0)
            throw new ArgumentException("Negative values are not allowed.");

        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
