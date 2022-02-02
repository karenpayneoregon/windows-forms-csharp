# About

For responding to forum questions.

```csharp
public class Operations
{
    /// <summary>
    /// Count occurrences for each char in a string
    /// </summary>
    public static List<Item> GetAllItems(string values)
    {
        var itemsGroup = (
                from chr in values.ToCharArray()
                group chr by chr into grp
                select new Item
                {
                    Character = grp.Key, 
                    Occurrences = grp.Count(), 
                    Code = Convert.ToInt32((int)grp.Key)
                })
            .ToList()
            .OrderBy(item => item.Character.ToString());

        return (from item in itemsGroup select item).ToList();

    }

    /// <summary>
    /// Count occurrences of numbers in array
    /// </summary>
    public static List<NumberItem> GetAllNumbers(int[] values)
    {
        IOrderedEnumerable<NumberItem> itemsGroup = (
                from chr in values
                group chr by chr into grp
                select new NumberItem
                {
                    Item = grp.Key,
                    Occurrences = grp.Count()
                })
            .ToList()
            .OrderBy(item => item.Item.ToString());

        return (from item in itemsGroup select item).ToList();

    }

    public static List<Item> GetNumbersOnly(string values) 
        => GetAllItems(values).Where(item => item.Code.Between(48, 57)).ToList();
}
```

**Helper extension**

```csharp
public static class Extensions
{
    public static int[] ToIntegerArray(this string[] sender)
    {

        var intArray = Array
            .ConvertAll(sender,
                (input) => new
                {
                    IsInteger = int.TryParse(input, out var integerValue),
                    Value = integerValue
                })
            .Where(result => result.IsInteger)
            .Select(result => result.Value)
            .ToArray();

        return intArray;

    }
    public static bool Between<T>(this IComparable<T> sender, T minimumValue, T maximumValue) 
        => sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;
}
```
