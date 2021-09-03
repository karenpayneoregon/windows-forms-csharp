using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassingDataBetweenForms.Classes;

namespace PassingDataBetweenForms
{
    public partial class EditNoteForm : Form
    {
        private Note _note;

        public EditNoteForm()
        {
            InitializeComponent();
        }
        public EditNoteForm(Note note)
        {
            InitializeComponent();

            _note = note;
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            TitleTextBox.Text = _note.Title;
            NoteTextBox.Text = _note.Content;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)))
            {
                MessageBox.Show("Both text boxes are required");
            }
            else
            {
                Operations.EditNote(new Note() { Title = TitleTextBox.Text, Content = NoteTextBox.Text });
                Close();
            }
        }
    }
}
