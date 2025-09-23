# C# 6.0 Features – Sample Projects

These projects show the language features introduced in **C# version 6.0**.  
Each sample is simple and illustrates a particular syntax enhancement.

Projects included:

- `P74_StringInterpolation_Nameof` — String interpolation & `nameof`  
- `P75_NullConditional` — Null‑conditional operator (`?.`, `?[]`)  
- `P76_ExceptionFilters` — `catch (Ex) when (...)` filters  
- `P77_UsingStatic` — `using static` to import static members  
- `P78_ExpressionBodied` — Expression‑bodied methods & read‑only properties  
- `P79_AutoPropertyInitializers` — Auto‑property initializers (including get‑only)  
- `P80_IndexInitializers` — Index & collection initializers  
- `P81_AwaitInCatchFinally` — `await` in `catch` and `finally` blocks  
- `P82_InterpolationAlignmentFormat` — Alignment / format specifiers in interpolations  
- `P83_UsingNullConditionalWithEvents` — Safe event invocation using `?.` / null conditional  

---

## 🚀 Key Features & Examples

### 1) String Interpolation & `nameof` (`P74_StringInterpolation_Nameof`)
```csharp
string name = "Alice";
Console.WriteLine($"Welcome, {name}");
Console.WriteLine(nameof(name)); // "name"
```

### 2) Null‑conditional operator (`P75_NullConditional`)
```csharp
Person p = null;
int? len = p?.Name?.Length;
```

### 3) Exception filters (`P76_ExceptionFilters`)
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

### 4) `using static` imports (`P77_UsingStatic`)
```csharp
using static System.Console;
WriteLine("Hello"); // no Console prefix needed
```

### 5) Expression‑bodied members (`P78_ExpressionBodied`)
```csharp
public string Name => _name;
public override string ToString() => $"{Name}";
```

### 6) Auto‑property initializers (`P79_AutoPropertyInitializers`)
```csharp
public string Name { get; set; } = "Unknown";
public int Count { get; } = 0;
```

### 7) Index / collection initializers (`P80_IndexInitializers`)
```csharp
var dict = new Dictionary<string,int>
{
    ["one"] = 1,
    ["two"] = 2
};
```

### 8) `await` in `catch` / `finally` (`P81_AwaitInCatchFinally`)
```csharp
try { /* ... */ }
catch (Exception ex) { await LogAsync(ex); }
finally { await CleanupAsync(); }
```

### 9) Interpolation alignment/format (`P82_InterpolationAlignmentFormat`)
```csharp
int value = 42;
Console.WriteLine($"Value: {value,10:D4}");
```

### 10) Null‑conditional with events (`P83_UsingNullConditionalWithEvents`)
```csharp
EventHandler handler = SomethingHappened;
handler?.Invoke(this, EventArgs.Empty);
```

---

## ▶ How to build & run

From repo root:
```bash
dotnet restore
dotnet build
dotnet run --project P74_StringInterpolation_Nameof
```

---

## ⚙ Why These Matter

C# 6 polished the language with:

- Less boilerplate (`nameof`, string interpolation, null‑conditional)  
- Safer code (`catch when`, null‑conditional on events)  
- Cleaner syntax (expression bodies, property initializers, `using static`)  
