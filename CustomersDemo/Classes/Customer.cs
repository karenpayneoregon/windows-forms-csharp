using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomersDemo
{
    public class Customer : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        public int CustomerIdentifier { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int CountryIdentifier { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}