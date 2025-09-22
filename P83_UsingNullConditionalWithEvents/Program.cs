using System;

class Button
{
    public event EventHandler Click;
    public void RaiseClick()
    {
        // ?. operator on event delegate (invoke if not null)
        Click?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        var b = new Button();
        b.Click += (s,e) => Console.WriteLine("Clicked!");
        b.RaiseClick();
        // Remove handlers, still safe
        b.Click = null;
        b.RaiseClick();
        Console.WriteLine("Done");
    }
}
