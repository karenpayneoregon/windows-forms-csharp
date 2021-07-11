using System;
using System.Windows.Forms;
using PassingDataBetweenForms.Classes;

namespace PassingDataBetweenForms
{
    public partial class AddNoteForm : Form
    {
        public AddNoteForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TitleTextBox.Text) && !string.IsNullOrWhiteSpace(NoteTextBox.Text))
            {
                Operations.NewNote(new Note() {Title = TitleTextBox.Text, Content =  NoteTextBox.Text});
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
