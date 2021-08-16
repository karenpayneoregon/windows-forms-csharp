using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp2.Classes
{
    public class BoxItem : INotifyPropertyChanged
    {
        private Unit _unit;
        private double _length;

        public double Length
        {
            get => _length;
            set => _length = value;
        }

        public int Width { get; set; }

        public Unit Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged();
                
                if (Unit == Unit.SI)
                {
                    Length *= 25.400013716;
                }
                else
                {
                    Length *= 0.0393701;
                }
                
            }
        }

        public override string ToString()
        {
            return Length.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
