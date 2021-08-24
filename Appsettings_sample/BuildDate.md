# About

[Getting the date of build of a .NET assembly at runtime](https://www.meziantou.net/getting-the-date-of-build-of-a-dotnet-assembly-at-runtime.htm)

```xml
<ItemGroup>
	<AssemblyAttribute Include="BuildDateAttribute">
		<_Parameter1>$([System.DateTime]::UtcNow.ToString("yyyyMMddHHmmss"))</_Parameter1>
	</AssemblyAttribute>
</ItemGroup>
```

Code

```csharp
using System;
using System.Globalization;

[AttributeUsage(AttributeTargets.Assembly)]
internal class BuildDateAttribute : Attribute
{
    public BuildDateAttribute(string value)
    {
        DateTime = DateTime.ParseExact(
            value,
            "yyyyMMddHHmmss",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None);
    }

    public DateTime DateTime { get; }
}

```

Usage

```csharp
private void BuildDateButton_Click(object sender, EventArgs e)
{
    DateTime buildDate = GetBuildDate(Assembly.GetExecutingAssembly());

}
private static DateTime GetBuildDate(Assembly assembly)
{
    var attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
    return attribute?.DateTime ?? default(DateTime);
}
```
