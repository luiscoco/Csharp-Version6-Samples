using System;
class Point
{
    public int X { get; }
    public int Y { get; }
    // Expression-bodied ctor not until C# 7, but methods/properties allowed in C# 6
    public Point(int x, int y) { X = x; Y = y; }
    public override string ToString() => $"({X},{Y})";
    public int Sum => X + Y; // expression-bodied read-only property
}
class Program
{
    static void Main()
    {
        var p = new Point(2,3);
        Console.WriteLine(p);         // uses expression-bodied ToString
        Console.WriteLine(p.Sum);     // expression-bodied property
    }
}
