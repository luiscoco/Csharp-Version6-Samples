using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Dictionary index initializers
        var map = new Dictionary<string,int>
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3
        };
        foreach(var kv in map) Console.WriteLine($"{kv.Key}={kv.Value}");
    }
}
