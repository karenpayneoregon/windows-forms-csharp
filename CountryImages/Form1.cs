using System;
using System.Windows.Forms;
using CountryImages.Classes;

namespace CountryImages
{

    public partial class Form1 : Form
    {
        private readonly BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Operations.CreateFile();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            bindingSource.DataSource = Operations.GetCountries();
            CountryListBox.DataSource = bindingSource;

            pictureBox1.DataBindings.Add("Image", bindingSource, "Image");
            CurrencyLabel.DataBindings.Add("Text", bindingSource, "Currency");
        }
    }
}
