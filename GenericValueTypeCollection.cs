using System;
using System.Collections.Generic;
using System.Linq;

public class StructCollection<U> where U : struct  // 1) Constrain to value types
{
    // 2) Private generic collection
    private List<U> elements = new List<U>();

    // 3) Method to add items to the private collection
    public void AddElement(U element)
    {
        elements.Add(element);
    }

    // 4) Method to return an item from the list
    public U GetElement(int position)
    {
        if (position >= 0 && position < elements.Count)
        {
            return elements[position];
        }
        throw new IndexOutOfRangeException("Position is out of range.");
    }

    // 5) Method to return a sorted collection with the items in descending order
    public List<U> GetSortedDescending()
    {
        return elements.OrderByDescending(x => x).ToList();
    }
}

// This is just to test the logic 
class Example
{
    static void Main(string[] args)
    {
        // Instantiate the generic class with an int type
        StructCollection<int> numbers = new StructCollection<int>();

        // Add items to the collection
        numbers.AddElement(5);
        numbers.AddElement(1);
        numbers.AddElement(8);
        numbers.AddElement(3);

        // Get an item from the collection (e.g., item at index 2)
        Console.WriteLine($"Item at index 2: {numbers.GetElement(2)}");

        // Get the sorted collection in descending order
        var sortedNumbers = numbers.GetSortedDescending();
        Console.WriteLine("Items in descending order:");
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}