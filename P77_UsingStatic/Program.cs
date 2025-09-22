using System;
using static System.Math;   // C# 6 'using static' to import static members

class Program
{
    static void Main()
    {
        // Use static members without qualifying with Math.
        Console.WriteLine(Sqrt(9) + Pow(2,3));
        Console.WriteLine(PI);
    }
}
