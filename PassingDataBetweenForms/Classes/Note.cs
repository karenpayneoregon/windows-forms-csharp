using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PassingDataBetweenForms.Classes
{
    public class Note : INotifyPropertyChanged
    {
        private string _title;
        private string _content;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() => Title;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
