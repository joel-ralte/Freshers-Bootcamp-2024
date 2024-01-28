using System;
using System.Collections.Generic;

interface ISearchStrategy
{
    void Filter(StartsWithStrategy strategy);
}

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

class StringListFilterController : ISearchStrategy
{
    private string[] array;
    public List<string> FilteredList { get; private set; } = new List<string>();

    public StringListFilterController(string[] inputArray)
    {
        array = inputArray;
    }

    public void Filter(StartsWithStrategy predicate)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (predicate.Invoke(array[i]))
            {
                FilteredList.Add(array[i]);
            }
        }
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
        List<string> filteredList;

        StringListFilterController filterObj = new StringListFilterController(inputArray);
        StartsWithStrategy predicate = new StartsWithStrategy();
        DisplayFilteredArray displayObj = new DisplayFilteredArray();

        predicate.SetStartsWith(startsWith);
        filterObj.Filter(predicate);
        filteredList = filterObj.FilteredList;
        displayObj.DisplayInTerminal(filteredList);
    }
}
