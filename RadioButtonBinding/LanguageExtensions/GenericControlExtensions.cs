using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadioButtonBinding.LanguageExtensions
{
    public static class GenericControlExtensions
    {
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
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
        public static List<GroupBox> GroupBoxList(this Control control) => 
            control.Descendants<GroupBox>().ToList();
        
        public static RadioButton RadioButtonChecked(this Control control, bool pChecked = true) =>
            control.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == pChecked);

        /// <summary>
        /// Get a list of RadioButtons 
        /// </summary>
        /// <param name="control">Control to iterate for RadioButtons</param>
        /// <returns></returns>
        public static List<RadioButton> RadioButtonList(this Control control) => 
            control.Descendants<RadioButton>().ToList();

    }

}
