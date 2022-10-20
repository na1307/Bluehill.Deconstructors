A collection of extension methods for deconstruction syntax in C#.

```csharp
int[] ints = { 1, 2, 3, 4, 5 };
var (one, two, three, four, five) = ints;
```

## Supported types
1. IList (Array, List, etc.) (Up to 15 items)
1. Reference Tuple (System.Tuple) (.NET 4.0 to 4.6.2 only, Up to 21 items)
1. KeyValuePair (.NET Framework only)

## Changelog
[Changelog](CHANGELOG.md)
