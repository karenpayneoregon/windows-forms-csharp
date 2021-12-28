using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JsonSampleDataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("SomeDate", typeof(DateTime));
            dataTable.Columns.Add("Currency", typeof(decimal));

            dataTable.Columns["SomeDate"].SetFormat("Format", "MM/dd/yy hh:mm tt");
            dataTable.Columns["Currency"].SetFormat("Format", "C2");
            
            foreach (var column in dataTable.Columns.List())
            {
                Console.WriteLine($"Col name: {column.ColumnName} type: {column.DataType.Name}");
                if (column.HasFormat())
                {
                    Console.WriteLine($"\tFormat: {column.Format()}");
                }
            }

            dataTable.Rows.Add(1, "Bill", new DateTime(2021, 12, 1, 3,34,0),123.456m);
            dataTable.Rows.Add(2, "Mary", new DateTime(2021, 12, 2,13,0,0),12m);
            dataTable.Rows.Add(3, "Anne", new DateTime(2021, 12, 3,9,12,34), 88.56m);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($@"{row.Field<int>("Id"), -3}");
                Console.WriteLine($@"{row.Field<DateTime>("SomeDate").ToString(dataTable.Columns["SomeDate"].Format())}");
                Console.WriteLine($@"{row.Field<decimal>("Currency").ToString(dataTable.Columns["Currency"].Format())}");
                Console.WriteLine();
            }
        }
    }

    public static class DataColumnExtensions
    {
        /// <summary>
        /// Get format for column or empty string if not set
        /// </summary>
        /// <param name="column">existing column</param>
        /// <returns>column format</returns>
        public static string Format(this DataColumn column) 
            => column.ExtendedProperties.Count > 0 ? column.ExtendedProperties["Format"].ToString() : "";

        /// <summary>
        /// Determine if column has a format set
        /// </summary>
        /// <param name="column">existing column</param>
        /// <returns>true if has format, false if no format set</returns>
        public static bool HasFormat(this DataColumn column) 
            => column.ExtendedProperties.Count > 0;

        /// <summary>
        /// Set format for DataColumn
        /// </summary>
        /// <param name="column">name of column</param>
        /// <param name="name">name to set</param>
        /// <param name="value">value to set</param>
        public static void SetFormat(this DataColumn column, string name, string value)
            => column.ExtendedProperties.Add(name, value);

        /// <summary>
        /// List of DataColumn in column collection
        /// </summary>
        /// <param name="source"><see cref="DataColumnCollection"/></param>
        /// <returns>list of DataColumnCollection</returns>
        public static List<DataColumn> List(this DataColumnCollection source) 
            => source.Cast<DataColumn>().ToList();
    }
}
