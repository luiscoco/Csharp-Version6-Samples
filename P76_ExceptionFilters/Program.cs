using System;
class Program
{
    static void Main()
    {
        try
        {
            Throw(42);
        }
        catch (InvalidOperationException ex) when (ex.Message.Contains("42"))
        {
            Console.WriteLine("Filtered: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Other InvalidOperationException: " + ex.Message);
        }
    }

    static void Throw(int x)
    {
        throw new InvalidOperationException("bad number " + x);
    }
}
