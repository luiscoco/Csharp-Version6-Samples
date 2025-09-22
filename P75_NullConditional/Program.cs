using System;
class Node
{
    public Node Next { get; set; }
    public string Value { get; set; }
}
class Program
{
    static void Main()
    {
        Node head = new Node { Value = "first" };
        // ?. short-circuits if null
        Console.WriteLine($"Head value length: {head?.Value?.Length}");
        head = null;
        Console.WriteLine($"Safe access when head is null: {head?.Value?.Length}");
        // ?[] demo
        string[] arr = null;
        Console.WriteLine($"Null-conditional indexer: {arr? [0]}");
    }
}
