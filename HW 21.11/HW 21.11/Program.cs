using System;
using System.Collections;
using System.Collections.Generic;
public class CustomCollection<T>
{
    private List<T> items = new List<T>();
    public int Count => items.Count;
    public void Sort()
    {
        items.Sort();
    }
    public void Add(T item)
    {
        items.Add(item);
    }
    public void SetDefaultAt(int index, T defaultValue)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index] = defaultValue;
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }
}
class Program
{
    static void Main()
    {
        CustomCollection<int> customCollection = new CustomCollection<int>();
        customCollection.Add(1);
        customCollection.Add(2);
        customCollection.Add(3);

        Console.WriteLine("Original Collection");
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }
        customCollection.Sort();

        Console.WriteLine("\nSorted Collection");
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }
        customCollection.SetDefaultAt(1, 10);

        Console.WriteLine("\nAfter SetDefaultAt:");
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }

    }
}