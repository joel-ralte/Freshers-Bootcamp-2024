using System;
using System.Collections.Generic;

public class DynamicArray<T>
{
    private T[] array;
    private int capacity;
    private int count;
    private ArrayResizer<T> resizer;

    public DynamicArray(int initialCapacity)
    {
        if (initialCapacity < 0)
        {
            throw new ArgumentException("Initial capacity cannot be lower than zero.", nameof(initialCapacity));
        }
        capacity = initialCapacity;
        array = new T[capacity];
        count = 0;
        resizer = new ArrayResizer<T>();
    }

    public void Add(int index, T item)
    {
        array[index] = item;
        count++;

        if (count == capacity)
        {
            resizer.Resize(ref array, ref capacity);
        }
    }

    public T this[int index]
    {
        get
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("Index is outside the valid range.");
            }

            return array[index];
        }
    }

    public int Count
    {
        get { return count; }
    }
}

public class ArrayResizer<T>
{
    public void Resize(ref T[] array, ref int capacity)
    {
        capacity *= 2;
        Array.Resize(ref array, capacity);
    }
}



public class Program
{
    static void Main()
    {
        DynamicArray<int> numbers = new DynamicArray<int>(2);
        numbers.Add(0, 100);
        numbers.Add(1, 200);
        numbers.Add(2, 300);
        numbers.Add(3, 400);
        int value = numbers[2];
        System.Console.WriteLine($"Total Number Of Items in Array:{numbers.Count} ,Value:{value} at index:2");

        DynamicArray<string> stringItems = new DynamicArray<string>(2);
        stringItems.Add(0, "100");
        stringItems.Add(1, "200");
        stringItems.Add(2, "300");
        stringItems.Add(3, "400");
        string itemValue = stringItems[3];
        System.Console.WriteLine($"Total Number Of Items in Array:{stringItems.Count} , Value:{itemValue} at index:3");
    }
}
