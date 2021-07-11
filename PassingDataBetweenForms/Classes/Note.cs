using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PassingDataBetweenForms.Classes
{
    public class Note : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public override string ToString() => Title;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
