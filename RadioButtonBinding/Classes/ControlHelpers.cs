using System.Windows.Forms;

namespace RadioButtonBinding.Classes
{
    /// <summary>
    /// Provides generic data binding for a RadioButton
    /// </summary>
    public static class ControlHelpers
    {
        public static void RadioCheckedBinding<T>(RadioButton radio, object dataSource, string dataMember, T trueValue)
        {
            var binding = new Binding(nameof(RadioButton.Checked), 
                dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
            
            binding.Parse += (s, args) =>
            {
                if ((bool)args.Value)
                {
                    args.Value = trueValue;
                }
            };
            
            binding.Format += (s, args) => args.Value = ((T)args.Value).Equals(trueValue);
            radio.DataBindings.Add(binding);
        }
    }
}
