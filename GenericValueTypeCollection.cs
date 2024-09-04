using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct  // 1) Constrain to value types
{
    // 2) Private generic collection
    private List<T> items = new List<T>();

    // 3) Method to add items to the private collection
    public void AddItem(T item)
    {
        items.Add(item);
    }

    // 4) Method to return an item from the list
    public T GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException("Index is out of range.");
    }

    // 5) Method to return a sorted collection with the items in descending order
    public List<T> GetSortedDescending()
    {
        return items.OrderByDescending(x => x).ToList();
    }
}


//this is just to test the logic 
class Program
{
    static void Main(string[] args)
    {
        // Instantiate the generic class with an int type
        ValueTypeCollection<int> collection = new ValueTypeCollection<int>();

        // Add items to the collection
        collection.AddItem(5);
        collection.AddItem(1);
        collection.AddItem(8);
        collection.AddItem(3);

        // Get an item from the collection (e.g., item at index 2)
        Console.WriteLine($"Item at index 2: {collection.GetItem(2)}");

        // Get the sorted collection in descending order
        var sortedItems = collection.GetSortedDescending();
        Console.WriteLine("Items in descending order:");
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item);
        }
    }
}