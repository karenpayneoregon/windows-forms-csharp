using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextBoxArrayAssignment
{
    public class TextBoxCustom : TextBox
    {
        [Category("Behavior")]
        public int Identifier
        {
            get
            {
                int.TryParse(Regex.Replace(Name, "[^0-9]", ""), 
                    out var identifier);

                return identifier;

            }
        }
    }
}
