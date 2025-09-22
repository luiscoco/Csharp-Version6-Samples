# C# 6.0 Features (Visual Studio 2015, .NET 4.6)

This solution demonstrates **major features introduced in C# 6.0**.

## Projects
- **P74_StringInterpolation_Nameof** — String interpolation and `nameof`.
- **P75_NullConditional** — Null-conditional operators `?.` and `?[]`.
- **P76_ExceptionFilters** — `catch (Ex) when (predicate)` filters.
- **P77_UsingStatic** — `using static` to import static members.
- **P78_ExpressionBodied** — Expression-bodied methods and read-only properties.
- **P79_AutoPropertyInitializers** — Auto-property initializers including get-only.
- **P80_IndexInitializers** — Dictionary/index initializers.
- **P81_AwaitInCatchFinally** — `await` in `catch` and `finally` blocks.
- **P82_InterpolationAlignmentFormat** — Alignment and formatting in interpolation.
- **P83_UsingNullConditionalWithEvents** — Safe event invocation with `?.`.

## Build & Run
```bash
dotnet restore
dotnet build
dotnet run --project P74_StringInterpolation_Nameof
```
Targets `.NET 10.0` with `<LangVersion>6</LangVersion>` to enforce C# 6.0 syntax.
