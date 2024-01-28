using System;
using System.Collections.Generic;

class StartsWithStrategy
{
    private string startsWith;

    public void SetStartsWith(string key)
    {
        startsWith = key;
    }

    public bool Invoke(string item)
    {
        return item.StartsWith(startsWith);
    }
}

class StringListFilterController
{
    private string[] array;
    private List<string> filteredList = new List<string>();

    public StringListFilterController(string[] inputArray)
    {
        array = inputArray;
    }

    public List<string> Filter(StartsWithStrategy predicate)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (predicate.Invoke(array[i]))
            {
                filteredList.Add(array[i]);
            }
        }
        return filteredList;
    }
}

class DisplayFilteredArray
{
    public void DisplayInTerminal(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        string[] inputArray = { "ask", "play", "type", "code", "asia", "app" };
        string startsWith = "as";
        List<string> filteredList = new List<string>();

        StringListFilterController filterObj = new StringListFilterController(inputArray);
        StartsWithStrategy predicate = new StartsWithStrategy();
        DisplayFilteredArray displayObj = new DisplayFilteredArray();

        predicate.SetStartsWith(startsWith);
        filteredList = filterObj.Filter(predicate);
        displayObj.DisplayInTerminal(filteredList);
    }
}
