# C# 6.0 Features - Sample Projects

These projects show the language features introduced in **C# version 6.0**.  
Each sample is simple and illustrates a particular syntax enhancement.

Projects included:

- `P78_StringInterpolation_Nameof` — String interpolation & `nameof`  
- `P79_NullConditional` — Null‑conditional operator (`?.`, `?[]`)  
- `P80_ExceptionFilters` — `catch (Ex) when (...)` filters  
- `P81_UsingStatic` — `using static` to import static members  
- `P82_ExpressionBodied` — Expression‑bodied methods & read‑only properties  
- `P83_AutoPropertyInitializers` — Auto‑property initializers (including get‑only)  
- `P84_IndexInitializers` — Index & collection initializers  
- `P85_AwaitInCatchFinally` — `await` in `catch` and `finally` blocks  
- `P86_InterpolationAlignmentFormat` — Alignment / format specifiers in interpolations  
- `P87_UsingNullConditionalWithEvents` — Safe event invocation using `?.` / null conditional  

---

## Key Features & Examples

### P78_StringInterpolation_Nameof - String Interpolation & `nameof`
```csharp
string name = "Alice";
Console.WriteLine($"Welcome, {name}");
Console.WriteLine(nameof(name)); // "name"
```

### P79_NullConditional - Null‑conditional operator
```csharp
Person p = null;
int? len = p?.Name?.Length;
```

### P80_ExceptionFilters - Exception filters
```csharp
try
{
    // Some code
}
catch (IOException ex) when (ex.Message.Contains("file not found"))
{
    // handle only certain IO exceptions
}
```

### P81_UsingStatic - using static
```csharp
using static System.Console;
WriteLine("Hello"); // no Console prefix needed
```

### P82_ExpressionBodied
```csharp
public string Name => _name;
public override string ToString() => $"{Name}";
```

### P83_AutoPropertyInitializers
```csharp
public string Name { get; set; } = "Unknown";
public int Count { get; } = 0;
```

### P84_IndexInitializers
```csharp
var dict = new Dictionary<string,int>
{
    ["one"] = 1,
    ["two"] = 2
};
```

### P85_AwaitInCatchFinally
```csharp
try { /* ... */ }
catch (Exception ex) { await LogAsync(ex); }
finally { await CleanupAsync(); }
```

### P86_InterpolationAlignmentFormat
```csharp
int value = 42;
Console.WriteLine($"Value: {value,10:D4}");
```

### P87_UsingNullConditionalWithEvents
```csharp
EventHandler handler = SomethingHappened;
handler?.Invoke(this, EventArgs.Empty);
```

---

## How to build & run

From repo root:
```bash
dotnet restore
dotnet build
dotnet run --project P74_StringInterpolation_Nameof
```

---

## Why These Matter

C# 6 polished the language with:

- Less boilerplate (`nameof`, string interpolation, null‑conditional)  
- Safer code (`catch when`, null‑conditional on events)  
- Cleaner syntax (expression bodies, property initializers, `using static`)  
