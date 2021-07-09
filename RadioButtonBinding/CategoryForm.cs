using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.Classes;
using RadioButtonBinding.LanguageExtensions;

namespace RadioButtonBinding
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            /*
             * Indicate were to create the radio buttons
             */
            CreateRadioButtons.ParentControl = CategoryFlowLayoutPanel;
            
            /*
             * Create a radio button for each line in categories.csv
             */
            CreateRadioButtons.CreateCategoryRadioButtons();
            
            /*
             * Setup event to get current checked radio button which
             * permits using the primary key to say get products by category.
             */
            CategoryFlowLayoutPanel.RadioButtonList().ForEach(radioButton => 
                radioButton.CheckedChanged += ( _ , _ ) =>
                {
                    if (radioButton?.Checked == true)
                    {
                        SelectedLabel.Text = $"{radioButton.Tag}, {radioButton.Text}";
                    }
                } 
            );
        }
        /// <summary>
        /// Example to get selected radio button if one is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedButton_Click(object sender, EventArgs e)
        {
            RadioButton selectedCategory = CategoryFlowLayoutPanel.RadioButtonChecked();

            MessageBox.Show(selectedCategory is null ?
                "Please select an option" :
                $"Key: {Convert.ToInt32(selectedCategory.Tag)}\nName:{selectedCategory.Text}");

        }
    }
}
