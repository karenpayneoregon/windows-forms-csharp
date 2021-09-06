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
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        
        public MainForm()
        {
            
            InitializeComponent();
            Shown += OnShown;

        }

        private void OnShown(object sender, EventArgs e)
        {
            
            Operations.AddNote += OperationsOnAddNote;
            Operations.SaveNote += OperationsOnSaveNote;
            
            Operations.Mocked();
            
            _bindingSource.DataSource = Operations.NotesList;
            NotesListBox.DataSource = _bindingSource;
            ContentsTextBox.DataBindings.Add("Text", _bindingSource, "Content");
            
        }

        private void OperationsOnSaveNote(Note note)
        {
            
            var current = (Note) _bindingSource.Current;
            current.Title = note.Title;
            current.Content = note.Content;
            
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditNoteForm( (Note) _bindingSource.Current );
            
            try
            {
                editForm.ShowDialog();
            }
            finally
            {
                editForm.Dispose();
            }
            
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var list = (List<Note>) _bindingSource.DataSource;

            _bindingSource.DataSource = list.OrderBy(note => note.Title);
            
        }
    }
}
