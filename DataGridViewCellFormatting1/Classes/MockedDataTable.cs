using System.Data;

namespace DataGridViewCellFormatting1.Classes
{
    public class MockedDataTable
    {
        public static DataTable Table()
        {
            var dt = new DataTable();

            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "id", 
                DataType = typeof(int), 
                AutoIncrement = true, 
                AutoIncrementSeed = 1
            });
            
            dt.Columns.Add(new DataColumn() { ColumnName = "Amount", DataType = typeof(int) });

            dt.Rows.Add(null, 200);
            dt.Rows.Add(null, 1000);
            dt.Rows.Add(null, -3200);
            dt.Rows.Add(null, -300);
            dt.Rows.Add(null, 500);


            return dt;
        }
    }
}