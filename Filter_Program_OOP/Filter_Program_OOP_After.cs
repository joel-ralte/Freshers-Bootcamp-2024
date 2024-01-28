using System;
using System.Collections.Generic;

class Container
{
    public string[] Array { get; set; }
    public string StartsWith { get; set; }

    public Container(string[] inputArray, string inputString)
    {
        Array = inputArray;
        StartsWith = inputString;
    }
}

class FilterArray
{
    public List<string> FilterMethod(string[] inputArray, string inputString)
    {
        List<string> filteredList = new List<string>();
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].StartsWith(inputString, StringComparison.OrdinalIgnoreCase))
            {
                filteredList.Add(inputArray[i]);
            }
        }
        return filteredList;
    }
}

class DisplayFilteredArray
{
    public void DisplayInTerminal(List<string> inputList)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            Console.WriteLine(inputList[i]);
        }
    }
}

class FilterStringArray
{
    static void Main()
    {
        string[] inputArray = { "ask", "play", "type", "code", "asia", "app" };
        List<string> filteredArray = new List<string>();

        Console.Write("Enter the starting string to search: ");
        string inputString = Console.ReadLine();

        Container containerObj = new Container(inputArray, inputString);
        FilterArray filterObj = new FilterArray();
        DisplayFilteredArray displayObj = new DisplayFilteredArray();

        filteredArray = filterObj.FilterMethod(containerObj.Array, containerObj.StartsWith);
        displayObj.DisplayInTerminal(filteredArray);
    }
}

