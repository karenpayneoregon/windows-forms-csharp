using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataGridViewColumns.Classes;

namespace DataGridViewColumns
{
    public partial class ConfigForm : Form
    {
        private readonly List<DataMapColumn> _dataMapColumns;
        public ConfigForm()
        {
            InitializeComponent();

            FileOperations.WriteConfigurationItems();
            FileOperations.WriteDataItems();

            _dataMapColumns = FileOperations.Columns;

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ConfigurationsListBox.DataSource = FileOperations.Configurations;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            var selected = (ConfigurationItem)ConfigurationsListBox.SelectedItem;

            var result = 
                _dataMapColumns.Where(dataColumnMap => 
                    dataColumnMap.ConfigurationId == selected.Id);

            foreach (var column in result)
            {
                builder.AppendLine($"{column.Name,-5}{column.DisplayName}");
            }

            textBox1.Text = builder.ToString();
        }
    }
}
