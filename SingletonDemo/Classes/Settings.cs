using System;

namespace SingletonDemo.Classes
{
    public sealed class Setting
    {
        private static readonly Lazy<Setting> Lazy = 
            new Lazy<Setting>(() => new Setting());
        public static Setting Instance => Lazy.Value;
        public decimal NumericUpDownValue { get; set; }
    }
}
