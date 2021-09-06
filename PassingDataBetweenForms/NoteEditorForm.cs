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
    public partial class NoteEditorForm : Form
    {
        private Note _note;
        private bool _newNote;
        public NoteEditorForm()
        {
            InitializeComponent();
            
            Operations.Transfer += OperationsOnTransferNote;
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            TitleTextBox.Text = _note.Title;
            NoteTextBox.Text = _note.Content;
        }

        private void OperationsOnTransferNote(Note note, bool newNote)
        {
            _newNote = newNote;
            _note = note;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_newNote)
            {
                if (!string.IsNullOrWhiteSpace(TitleTextBox.Text) && !string.IsNullOrWhiteSpace(NoteTextBox.Text))
                {
                    Operations.NewNote(new Note() { Title = TitleTextBox.Text, Content = NoteTextBox.Text });
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
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
}
