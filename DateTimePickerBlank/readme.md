# About

Nullable DateTimePicker, originally from 

[How to alter a .NET DateTimePicker control to allow enter null values?](https://stackoverflow.com/questions/284364/how-to-alter-a-net-datetimepicker-control-to-allow-enter-null-values)

I added the following and tidied up code.

```csharp
/// <summary>
/// Indicates if Value has a date or not
/// </summary>
[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
public bool IsNullValue => Value == DateTime.MinValue;
```

