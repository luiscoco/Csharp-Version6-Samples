using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
        try
        {
            await Task.Delay(50);
            throw new InvalidOperationException("boom");
        }
        catch (InvalidOperationException)
        {
            await Task.Delay(50); // await inside catch (C# 6)
            Console.WriteLine("Recovered after await in catch.");
        }
        finally
        {
            await Task.Delay(50); // await inside finally (C# 6)
            Console.WriteLine("Cleanup after await in finally.");
        }
    }
}
