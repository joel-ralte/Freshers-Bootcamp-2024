using System;
using System.Collections.Generic;

class FilterStringArray
{
    static void Main()
    {
        string[] inputArray = { "ask", "play", "type", "code", "asia", "app" };
        List<string> filteredList = new List<string>();

        Console.Write("Enter the starting string to search: ");
        string inputString = Console.ReadLine();
        Predicate<string> startsWith = str => str.StartsWith(inputString, StringComparison.OrdinalIgnoreCase);

        filteredList = Filter(inputArray, startsWith);
        DisplayInTerminal(filteredList);
    }

    static List<string> Filter(string[] inputArray, Predicate<string> startsWith)
    {
        List<string> filteredList = new List<string>();
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (startsWith(inputArray[i]))
            {
                filteredList.Add(inputArray[i]);
            }
        }
        return filteredList;
    }

    static void DisplayInTerminal(List<string> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            Console.WriteLine(inputList[i]);
        }
    }
}
