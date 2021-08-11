#nullable enable
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
using Microsoft.EntityFrameworkCore;
using PictureBoxSqlServer_efcore.Classes;
using PictureBoxSqlServer_efcore.Data;
using PictureBoxSqlServer_efcore.Models;

namespace PictureBoxSqlServer_efcore
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _categoriesBindingSource = new ();
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }
        
        private async void OnShown(object? sender, EventArgs e)
        {
            await Task.Delay(100);
            
            await using var context = new NorthWindContext();
            
            _categoriesBindingSource.DataSource = await context.Categories
                .Where(category => category.Picture != null)
                .ToListAsync();
            
            _categoriesBindingSource.PositionChanged += CategoriesBindingSourceOnPositionChanged;
            
            CategoryListBox.DataSource = _categoriesBindingSource;
            
            CategoryListBox.KeyDown += CategoryListBoxOnKeyDown;
            CategoryListBox.DoubleClick += CategoryListBoxOnDoubleClick;
            
            SetPicture();
            
        }



        private void CategoriesBindingSourceOnPositionChanged(object? sender, EventArgs e)
        {
            SetPicture();
        }

        private void SetPicture()
        {
            var category = (Categories) _categoriesBindingSource.Current;
            pictureBox1.Image = category.Image;
            DescriptionLabel.Text = category.Description;
        }

        private void ShowFormButton_Click(object sender, EventArgs e)
        {
            ShowChildForm();
        }
        
        private void CategoryListBoxOnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowChildForm();
            }
        }
        private void CategoryListBoxOnDoubleClick(object? sender, EventArgs e)
        {
            ShowChildForm();
        }

        private void ShowChildForm()
        {
            var imageArray = pictureBox1.Image.ToBytes();
            var category = (Categories)_categoriesBindingSource.Current;
            
            var f = new Form2(imageArray, category.CategoryName);

            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
    }
}
