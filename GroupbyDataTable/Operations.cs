using System.Data;
using System.Linq;

namespace GroupbyDataTable
{
    public class Operations 
    {
        public static DataTable Mocked()
        {
            var table = new DataTable();

            table.Columns.Add(new DataColumn("TaxRate", typeof(decimal)));
            table.Columns.Add(new DataColumn("Value", typeof(decimal)));
            table.Columns.Add(new DataColumn("TaxAmount", typeof(decimal)));
            table.Columns.Add(new DataColumn("FinalValue", typeof(decimal), "Value + TaxAmount"));

            table.Rows.Add(5, 1000, 50);
            table.Rows.Add(5, 2000, 100);
            
            table.Rows.Add(10, 1000, 100);
            table.Rows.Add(10, 2000, 200);
            
            table.Rows.Add(15, 1000, 150);
            table.Rows.Add(15, 2000, 300);

            return table;
            
        }


        public static DataTable GroupData(DataTable dt)
        {

            return dt.AsEnumerable()
                .GroupBy(row => DataRowExtensions.Field<decimal>(row, "TaxRate"))
                .Select(grouped =>
                {
                    var row = dt.NewRow();

                    row["TaxRate"] = grouped.Key;
                    row["Value"] = grouped.Sum(dRow => dRow.Field<decimal>("Value"));
                    row["TaxAmount"] = grouped.Sum(dRow => dRow.Field<decimal>("TaxAmount"));
                    row["FinalValue"] = grouped.Sum(dRow => dRow.Field<decimal>("FinalValue"));

                    return row;
                }).CopyToDataTable();
        }
    }
}