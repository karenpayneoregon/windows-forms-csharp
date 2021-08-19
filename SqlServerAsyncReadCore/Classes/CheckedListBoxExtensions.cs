using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SqlServerAsyncReadCore.Classes
{
public static partial class CheckedListBoxExtensions
{
    /// <summary>
    /// Raw method for inspecting data in a <see cref="CheckedListBox"/> where the DataSource is a <see cref="DataTable"/>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="primaryKeyName">Primary key in DataTable</param>
    /// <returns>List of <see cref="CheckedData"/></returns>
    public static List<CheckedData> IndexList(this CheckedListBox sender, string primaryKeyName)
    {
        return
        (
            from item in sender.Items.Cast<DataRowView>()
                .Select(
                    (data, index) =>
                        new CheckedData
                        {
                            Row = data.Row,
                            Index = index,
                            Identifier = data.Row.Field<int>(primaryKeyName)
                        }
                )
                .Where((x) => sender.GetItemChecked(x.Index))
            select item
        ).ToList();
    }
    /// <summary>
    /// Get checked items into a list of <see cref="ProductItem"/> in a <see cref="CheckedListBox"/> where the DataSource is a <see cref="DataTable"/>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="primaryKeyName">Primary key in DataTable</param>
    /// <returns>List of <see cref="ProductItem"/></returns>
    public static List<ProductItem> ProductSelectedList(this CheckedListBox sender, string primaryKeyName)
    {
        return
        (
            from item in sender.Items.Cast<DataRowView>()
                .Select(
                    (data, index) =>
                        new ProductItem
                        {
                            Index = index,
                            Identifier = data.Row.Field<int>(primaryKeyName),
                            ProductName = data.Row.Field<string>("ProductName")

                        }
                )
                .Where((x) => sender.GetItemChecked(x.Index))
            select item
        ).ToList();
    }
}
}