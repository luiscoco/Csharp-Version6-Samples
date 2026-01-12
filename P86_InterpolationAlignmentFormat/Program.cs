using System;
class Program
{
    static void Main()
    {
        var name = "Ana";
        var value = 1234.5678;
        // Alignment and format strings inside interpolation
        Console.WriteLine($"|{name,10}|");
        Console.WriteLine($"Value = {value:0.00}");
        // Nested interpolation with conditional
        Console.WriteLine($"{(name ?? "unknown"),-10} -> {DateTime.UtcNow:yyyy-MM-dd}");
    }
}
