using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ListBoxFromFileList.Classes
{
    public class FileItem : INotifyPropertyChanged
    {
        private string _fullName;

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }

        [JsonIgnore]
        public string FileName => Path.GetFileName(FullName);
        [JsonIgnore]
        public string FolderName => Path.GetDirectoryName(FullName);
        public override string ToString() => FileName;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
