using System;
class Person { public string Name { get; set; } }
class Program
{
    static void Main()
    {
        var p = new Person { Name = "Ana" };
        // String interpolation + nameof
        Console.WriteLine($"Hello, {p.Name}! Property: {nameof(Person.Name)}");
        // Interpolated verbatim string ($@) for paths
        var path = $@"C:\Users\{p.Name}\Documents";
        Console.WriteLine(path);
    }
}
