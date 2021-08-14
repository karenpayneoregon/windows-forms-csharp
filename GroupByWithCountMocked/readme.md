# About

Shows how to perform a GroupBy with count

![img](assets/groupedData.png)

Using `ConnectionData`, group by `ConnectionType` property.

```csharp
namespace GroupByWithCountMocked.Classes
{
    public enum ConnectionType
    {
        IP,
        COM
    }
    public class ConnectionData
    {
        public ConnectionType ConnectionType { get; set; }
        public string ComPort { get; set; }
        public string TcpPort { get; set; }
        public string ConnectionName { get; set; }
        

        public override string ToString() => ConnectionName;

    }
    ```

}
```
</br>

![img](assets/groupby_1.png)