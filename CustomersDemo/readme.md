# About

In [ListBoxSaveForm](https://github.com/karenpayneoregon/windows-forms-csharp/blob/Version1/CustomersDemo/ListBoxSaveForm.cs) has code to show the basics of adding a [Customer](https://github.com/karenpayneoregon/windows-forms-csharp/blob/Version1/CustomersDemo/Classes/Customer.cs) into a ListBox with it's DataSource of type List&lt;[Customer](https://github.com/karenpayneoregon/windows-forms-csharp/blob/Version1/CustomersDemo/Classes/Customer.cs)> via a [BindingList](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-5.0) and [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource?view=net-5.0).

:small_orange_diamond: Coded with .NET Core 5, C#9 while with little effort will work with say .NET Frameowrk 4.8

- Add code is basic, an improvement would be to have each property of the Customer class using [data annotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-5.0)
- `Edit` code is half-backed, deserves separate logic but enough to get going.
- `Save` code writes contents of the ListBox to a Json file in the application folder using [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/api/system.text.json?view=net-5.0) methods. Alternative would be [NewtonSoft Json.net](https://www.nuget.org/packages/Newtonsoft.Json/).
- `Delete` not coded but can be done via the BindingSource.Remove... methods.
- [INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-5.0) provides change notification for Customer properties

![img](assets/figure1.png)