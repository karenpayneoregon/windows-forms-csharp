using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckListBoxProducts.Classes;
using Newtonsoft.Json;

namespace CheckListBoxProducts
{
    public partial class SaveItemsForm : Form
    {
        private List<Product> _products = new List<Product>();
        public SaveItemsForm()
        {
            InitializeComponent();
            Shown += OnShown;
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            List<ProductItem> checkedItems = ProductCheckedListBox.IndexList();
            if (checkedItems.Count > 0)
            {
                JsonOperations.Save(checkedItems);
            }
            else
            {
                JsonOperations.Save(new List<ProductItem>());
            }
        }

        private void OnShown(object sender, EventArgs e)
        {
            _products = SqlServerOperations.ProductsByCategoryIdentifier(1);

            ProductCheckedListBox.DataSource = _products;

            /*
             * Search for each product by id, if in the CheckedListBox check it
             */
            var items = JsonOperations.Read();
            if (items.Count >0 )
            {
                items.ForEach( x => ProductCheckedListBox.SetChecked(x.ProductID));
            }
        }
    }

    public class JsonOperations
    {
        /// <summary>
        /// In your app you need to setup a different file name for each CheckedListBox
        /// </summary>
        public static string FileName => 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Checked.json");

        /// <summary>
        /// Save only checked products
        /// </summary>
        /// <param name="list"></param>
        public static void Save(List<ProductItem> list)
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(FileName, json);
        }

        /// <summary>
        /// Read back if file exists
        /// </summary>
        /// <returns></returns>
        public static List<ProductItem> Read()
        {
            List<ProductItem> list = new List<ProductItem>();

            if (File.Exists(FileName))
            {
                list = JsonConvert.DeserializeObject<List<ProductItem>>(File.ReadAllText(FileName));
            }

            return list;
        }
    }



    public static class CheckedListBoxExtensions
    {
        public static List<ProductItem> IndexList(this CheckedListBox sender)
        {
            return
            (
                from item in sender.Items.Cast<Product>()
                    .Select(
                        (data, index) =>
                            new ProductItem()
                            {
                                ProductID = data.ProductID,
                                Index = index
                            }
                    )
                    .Where((x) => sender.GetItemChecked(x.Index))
                select item
            ).ToList();
        }
        public static void SetChecked(this CheckedListBox sender, int identifier, bool checkedState = true)
        {
            var result = sender.Items.Cast<Product>()
                .Select((item, index) => new CheckItem
                {
                    Product = item, 
                    Index = index
                })
                .FirstOrDefault(@this => @this.Product.ProductID == identifier);

            if (result != null)
            {
                sender.SetItemChecked(result.Index, checkedState);
            }
        }
    }

    public class CheckItem
    {
        public Product Product { get; set; }
        public int Index { get; set; }
    }

}
