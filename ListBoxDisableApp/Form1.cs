using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ListBoxDisableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            listBox1.Items.Add(new ListItem { Name = "LocalMachine" });
            listBox1.Items.Add(new ListItem { Name = "============", Disable = true});
            listBox1.Items.Add(new ListItem { Name = "runKey_" });
            listBox1.Items.Add(new ListItem { Name = "runKey_A" });
            listBox1.Items.Add(new ListItem { Name = "runKey_B" });
            listBox1.Items.Add(new ListItem { Name = "runKey_C" });
            listBox1.Items.Add(new ListItem { Name = "runKey_D" });

            listBox1.Items.Add(new ListItem { Name = "" });

            listBox1.Items.Add(new ListItem { Name = "CurrentUser" });
            listBox1.Items.Add(new ListItem { Name = "============", Disable = true });
            listBox1.Items.Add(new ListItem { Name = "runKey1_" });
            listBox1.Items.Add(new ListItem { Name = "runKey_AA" });
            listBox1.Items.Add(new ListItem { Name = "runKey_BB" });
            listBox1.Items.Add(new ListItem { Name = "runKey_CC" });
            listBox1.Items.Add(new ListItem { Name = "runKey_DD" });


            var items = listBox1.Items.OfType<ListItem>()
                .Select((item, index) => new { Index = index, Item = item })
                .Where(x => x.Item.Disable)
                .ToList();

            foreach (var item in items)
            {
                listBox1.DisableItem(item.Index);
            }
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            var current = (ListItem)listBox1.SelectedItem;
            MessageBox.Show(current != null ? $"{current.Name} {current.Disable}" : $"Disabled item");
        }
    }
}
