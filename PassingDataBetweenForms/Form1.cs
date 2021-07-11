using System;
using System.Windows.Forms;
using PassingDataBetweenForms.Classes;

namespace PassingDataBetweenForms
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;

        }


        private void OnShown(object sender, EventArgs e)
        {
            Operations.AddNote += OperationsOnAddNote;
            
            Operations.Mocked();
            
            _bindingSource.DataSource = Operations.NotesList;
            NotesListBox.DataSource = _bindingSource;
            ContentsTextBox.DataBindings.Add("Text", _bindingSource, "Content");
        }

        private void OperationsOnAddNote(Note note)
        {
            _bindingSource.Add(note);
            NotesListBox.SelectedIndex = NotesListBox.Items.Count - 1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddNoteForm();
            try
            {
                addForm.ShowDialog();
            }
            finally
            {
                addForm.Dispose();
            }

        }
    }
}
