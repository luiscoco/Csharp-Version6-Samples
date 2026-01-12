using System;
class Settings
{
    // Auto-property initializers and get-only auto-property with initializer
    public string Mode { get; } = "Default";
    public int RetryCount { get; set; } = 3;
}
class Program
{
    static void Main()
    {
        var s = new Settings();
        Console.WriteLine($"Mode={s.Mode}, RetryCount={s.RetryCount}");
        s.RetryCount = 5;
        Console.WriteLine($"Updated RetryCount={s.RetryCount}");
    }
}
