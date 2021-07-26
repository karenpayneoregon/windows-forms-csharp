using System;
using System.Collections.Generic;

namespace PassingDataBetweenForms.Classes
{
    public class Operations
    {
        public delegate void OnAddNote(Note note);
        public static event OnAddNote AddNote;

        public static List<Note> NotesList = new List<Note>();

        public static Note DefaultNote => new Note() { Title = "Default title", Content = "Content"};
        
        /// <summary>
        /// Pass new Note to listeners
        /// </summary>
        /// <param name="note"></param>
        public static void NewNote(Note note)
        {
            AddNote?.Invoke(note);
        }

        /// <summary>
        /// Edit note, do some validation
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static Note EditNote(Note note)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Load mocked data, for a real application if persisting data use <see cref="LoadNotes"/>
        /// </summary>
        public static void Mocked()
        {
            NotesList.Add(new Note()
            {
                Title = "First", 
                Content = "My note"
            });
            NotesList.Add(new Note()
            {
                Title = "Second",
                Content = "Some content"
            });
        }

        /// <summary>
        /// For a real application which persist your notes we would load from
        /// - a database
        /// - file (xml, json etc)
        /// </summary>
        /// <returns></returns>
        public static List<Note> LoadNotes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a note in <see cref="NotesList"/>
        /// </summary>
        /// <param name="note"></param>
        public static void Delete(Note note)
        {
            throw new NotImplementedException();
        }

        public static Note FindByTitle(string title)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save data to the data source loaded from <see cref="LoadNotes"/>
        /// </summary>
        /// <returns>
        /// Named value tuple
        /// success - operation was successful
        /// exception - if failed what was the cause
        /// </returns>
        public static (bool success, Exception exception) Save()
        {
            throw new NotImplementedException();
        }
    }
}
