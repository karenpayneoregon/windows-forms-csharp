using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreateDynamicControls.Classes.Extensions
{
    public static class ControlExtensions
    {
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
        public static List<RadioButton> RadioButtonList(this Control control) => 
            control.Descendants<RadioButton>().ToList();
        
        public static List<RadioButton> RadioButtonListChecked(this Control control) => 
            control.RadioButtonList().Where(rb => rb.Checked).ToList();

    }
}