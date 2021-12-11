using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ReadFromClipboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                IDataObject ClipboardData = Clipboard.GetDataObject();

                if (ClipboardData != null)
                {
                    //Next proceed only of the copied data is in the CSV format indicating Excel content
                    if (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue))
                    {

                        var clipboardStream = new StreamReader((Stream)ClipboardData.GetData(
                            DataFormats.CommaSeparatedValue));

                        var dataTable = new DataTable { TableName = "ExcelData" };
                        while (clipboardStream.Peek() > 0)
                        {
                            Array singleRowData = null;


                            int counter = 0;
                            var formattedData = clipboardStream.ReadLine();

                            singleRowData = formattedData.Split(",".ToCharArray());

                            if (dataTable.Columns.Count <= 0)
                            {
                                for (counter = 0; counter <= singleRowData.GetUpperBound(0); counter++)
                                {
                                    dataTable.Columns.Add();
                                }
                                counter = 0;
                            }

                            var rowNew = dataTable.NewRow();

                            for (counter = 0; counter <= singleRowData.GetUpperBound(0); counter++)
                            {
                                rowNew[counter] = singleRowData.GetValue(counter);
                            }

                            counter = 0;
                            if (singleRowData.Length == 3)
                            {
                                var lastCellValue = singleRowData.GetValue(2).ToString();
                                if (int.TryParse(lastCellValue, out var data))
                                {
                                    if (data > 0)
                                    {
                                        dataTable.Rows.Add(rowNew);
                                    }
                                }
                            }
                            rowNew = null;
                        }

                        clipboardStream.Close();
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Clipboard data does not seem to be copied from Excel!");
                    }
                }
                else
                {
                    MessageBox.Show("Clipboard is empty!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
