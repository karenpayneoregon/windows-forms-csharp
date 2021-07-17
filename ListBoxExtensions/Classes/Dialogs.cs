using System.Windows.Forms;

namespace MediaFileDemo.Classes
{
    public static class Dialogs
    {
        public static bool Question(string text, string title = "Question") => 
            (MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
    }
}