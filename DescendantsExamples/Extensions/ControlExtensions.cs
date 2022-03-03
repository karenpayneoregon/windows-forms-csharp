using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DescendantsExamples.Extensions
{
    public static class ControlExtensions
    {
        public static RadioButton RadioButtonChecked(this Control control, bool Checked = true) =>
            control.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == Checked);

        public static List<CheckBox> CheckBoxList(this Control control) => 
            control.Descendants<CheckBox>().ToList();
        public static List<ComboBox> ComboBoxList(this Control control) => 
            control.Descendants<ComboBox>().ToList();

        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
