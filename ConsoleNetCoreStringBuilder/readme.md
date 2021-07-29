Simple example for extending StringBuilder, in this case a contains method case insensitive.

```csharp
public static class Extensions
{
    public static bool Contains(this StringBuilder sender, string text) => 
        sender.ToString().Contains(text, StringComparison.OrdinalIgnoreCase);
}
```