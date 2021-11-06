using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonSampleDataGridView
{
    public partial class Form1 : Form
    {
        private readonly BindingSource customersBindingSourceTop = new BindingSource();
        private readonly BindingSource customersBindingSourceBottom = new BindingSource();
        private GridConfiguration gridConfiguration;
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            DataOperations.Save(gridConfiguration);
        }

        private void OnShown(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            gridConfiguration = DataOperations.ReadConfiguration();

            for (int index = 0; index < gridConfiguration.ColumnDefinitions.Count; index++)
            {
               
                if (gridConfiguration.ColumnDefinitions[index].Visible)
                {
                    dataGridView1.Columns.Add(new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell(), DataPropertyName = gridConfiguration.ColumnDefinitions[index].DataPropertyName, HeaderText = gridConfiguration.ColumnDefinitions[index].HeaderText });
                }

            }

            customersBindingSourceTop.DataSource = gridConfiguration.Customers;
            dataGridView1.DataSource = customersBindingSourceTop;

            var table = gridConfiguration.Customers.ToDataTable();
            
            for (int columnIndex = 0; columnIndex < gridConfiguration.ColumnDefinitions.Count; columnIndex++)
            {
                if (!gridConfiguration.ColumnDefinitions[columnIndex].Visible)
                {
                    table.Columns[gridConfiguration.ColumnDefinitions[columnIndex].DataPropertyName].ColumnMapping = MappingType.Hidden;
                }
            }

            customersBindingSourceBottom.DataSource = table;
            dataGridView2.DataSource = customersBindingSourceBottom;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                var current = gridConfiguration.ColumnDefinitions.FirstOrDefault(ColumnDefinition => ColumnDefinition.DataPropertyName == column.DataPropertyName);
                if (current != null)
                {
                    column.HeaderText = current.HeaderText;
                }
            }

            var list = table.DataTableToList<Customer>();
        }
    }

    public class DataOperations
    {
        public static readonly string FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.json");
        public static GridConfiguration ReadConfiguration()
        {
            if (!File.Exists(FileName))
            {
                MockData();
            }

            return JsonConvert.DeserializeObject<GridConfiguration>(File.ReadAllText(FileName));
        }

        public static void Save(GridConfiguration source)
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(source, Formatting.Indented));
        }

        /// <summary>
        /// Create mocked data, save as json
        /// </summary>
        public static void MockData()
        {
            List<ColumnDefinition> definitions = new List<ColumnDefinition>
            {
                new ColumnDefinition() { DataPropertyName = "Identifier", HeaderText = "Id", Visible = false },
                new ColumnDefinition() { DataPropertyName = "CompanyName", HeaderText = "Company", Visible = true },
                new ColumnDefinition() { DataPropertyName = "ContactType", HeaderText = "Contact type", Visible = true},
                new ColumnDefinition() { DataPropertyName = "ContactName", HeaderText = "Contact", Visible = true},
                new ColumnDefinition() { DataPropertyName = "GenderType", HeaderText = "Gender", Visible = true},
                new ColumnDefinition() { DataPropertyName = "ContactTypeIdentifier", HeaderText = "", Visible = false },
                new ColumnDefinition() { DataPropertyName = "GenderIdentifier", HeaderText = "", Visible = false }
            };

            List<Customer> customers = new List<Customer>
            {
                new Customer() { Identifier = 1, CompanyName = "Alfreds Futterkiste", ContactType = "Owner", ContactName = "Maria Anders", GenderType = "Female", ContactTypeIdentifier = 7, GenderIdentifier = 1 },
                new Customer() { Identifier = 2, CompanyName = "Die Wandernde Kuh", ContactType = "Owner", ContactName = "Rita Müller", GenderType = "Female", ContactTypeIdentifier = 7, GenderIdentifier = 1 },
                new Customer() { Identifier = 3, CompanyName = "Chop-suey Chinese", ContactType = "Assistant Sales Agent", ContactName = "Yang Wang", GenderType = "Male", ContactTypeIdentifier = 2, GenderIdentifier = 2}
            };

            GridConfiguration gridConfiguration = new GridConfiguration() { ColumnDefinitions = definitions, Customers = customers};

            string json = JsonConvert.SerializeObject(gridConfiguration, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }
    }
    public class ColumnDefinition
    {
        public string HeaderText { get; set; }
        public string DataPropertyName { get; set; }
        public bool Visible { get; set; }
        public override string ToString() => DataPropertyName;
    }


    public class GridConfiguration
    {
        public List<ColumnDefinition> ColumnDefinitions { get; set; }
        public List<Customer> Customers { get; set; }
    }

    public class Customer : INotifyPropertyChanged
    {
        private int _identifier;
        private string _companyName;
        private string _contactType;
        private string _contactName;
        private string _genderType;
        private int _contactTypeIdentifier;
        private int _genderIdentifier;

        public int Identifier
        {
            get => _identifier;
            set { _identifier = value; OnPropertyChanged(); }
        }

        public string CompanyName
        {
            get => _companyName;
            set { _companyName = value; OnPropertyChanged(); }
        }

        public string ContactType
        {
            get => _contactType;
            set { _contactType = value; OnPropertyChanged(); }
        }

        public string ContactName
        {
            get => _contactName;
            set { _contactName = value; OnPropertyChanged(); }
        }

        public string GenderType
        {
            get => _genderType;
            set { _genderType = value; OnPropertyChanged(); }
        }

        public int ContactTypeIdentifier
        {
            get => _contactTypeIdentifier;
            set { _contactTypeIdentifier = value; OnPropertyChanged(); }
        }

        public int GenderIdentifier
        {
            get => _genderIdentifier;
            set { _genderIdentifier = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class Extensions
    {
        /// <summary>
        /// Convert a list to a DataTable
        /// </summary>
        /// <typeparam name="TSource">Type to convert from</typeparam>
        /// <param name="data"><see cref="TSource"/></param>
        /// <returns></returns>
        public static DataTable ToDataTable<TSource>(this IList<TSource> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(TSource));
            DataTable table = new DataTable();

            for (int index = 0; index < props.Count; index++)
            {
                PropertyDescriptor prop = props[index];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];

            foreach (TSource item in data)
            {
                for (int index = 0; index < values.Length; index++)
                {
                    values[index] = props[index].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }

        /// <summary>
        /// Convert DataTable to List of T
        /// </summary>
        /// <typeparam name="TSource">Type to return from DataTable</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List of <see cref="TSource"/>Expected type list</returns>
        public static List<TSource> DataTableToList<TSource>(this DataTable table) where TSource : new()
        {
            List<TSource> list = new List<TSource>();

            var typeProperties = typeof(TSource).GetProperties().Select(propertyInfo => new
            {
                PropertyInfo = propertyInfo,
                Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
            }).ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {
                
                TSource current = new TSource();

                foreach (var typeProperty in typeProperties)
                {
                    object value = row[typeProperty.PropertyInfo.Name];
                    object safeValue = value == null || DBNull.Value.Equals(value) ? null : Convert.ChangeType(value, typeProperty.Type);
                    typeProperty.PropertyInfo.SetValue(current, safeValue, null);
                }

                list.Add(current);
            }

            return list;
        }
    }

}
