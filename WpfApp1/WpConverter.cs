using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    public class WpConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is null ? 0 : int.TryParse(value.ToString(), out var valueResult) ? valueResult - 200 : 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }

    public class Employee : IDataErrorInfo
    {
        public string Error { get; }

        public string this[string columnName]
        {
            get
            {
                string errorMessage = null;

                switch (columnName)
                {
                    case "FirstName":
                        if (string.IsNullOrWhiteSpace(FirstName))
                        {
                            errorMessage = "First Name is required.";
                        }
                        break;
                    case "LastName":
                        if (string.IsNullOrWhiteSpace(LastName))
                        {
                            errorMessage = "Last Name is required.";
                        }
                        break;
                    case "SomeNumber":
                        if (SomeNumber is null)
                        {
                            errorMessage = "Some number is required";
                        }
                        break;
                }

                return errorMessage;
            }
        }

        public string LastName { get; set; }

        public string FirstName { get; set; }
        public int? SomeNumber { get; set; }
    }
}
