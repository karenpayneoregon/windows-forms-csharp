using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RadioButtonBinding.Classes
{
    public class CreateRadioButtons
    {
        public List<RadioButton> RadioButtons { get; set; }
        public string RadioBaseName { get; set; }
        public static int Base { get; set; }
        public static int BaseAddition { get; set; }
        /// <summary>
        /// Parent control to place RadioButton controls on
        /// </summary>
        public static Control ParentControl { get; set; }

        /// <summary>
        /// Create one RadioButton for each category read from a comma delimited
        /// file. Could also change from reading a file to reading from a database
        /// table.
        /// </summary>
        public static void CreateCategoryRadioButtons()
        {
            var categories = DataOperations.ReadCategoriesFromCommaDelimitedFile();

            foreach (var category in categories)
            {
                RadioButton radioButton = new()
                {
                    Name = $"{category.Name}RadioButton",
                    Text = category.Name,
                    Location = new Point(5, Base),
                    Parent = ParentControl,
                    Tag = category.CategoryId,
                    Visible = true
                };
                
                ParentControl.Controls.Add(radioButton);
                Base += BaseAddition;
            }
        }
    }
}
