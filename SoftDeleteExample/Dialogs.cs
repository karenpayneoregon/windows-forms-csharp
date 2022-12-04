using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace SoftDeleteExample
{
    public static class Dialogs
    {
        public static bool Question(string text) =>
            (Show(text, Application.ProductName, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
    }
}
