using System;

namespace SingletonDemo.Classes
{
    public sealed class ApplicationJobs
    {

        private static readonly Lazy<ApplicationJobs> Lazy = new Lazy<ApplicationJobs>(() =>
                new ApplicationJobs());

        public delegate void OnValueChanged(int value);
        /// <summary>
        /// Notify any listeners that <see cref="Value"/> has changed
        /// </summary>
        public static event OnValueChanged ValueChanged;

        /// <summary>
        /// Entry point
        /// </summary>
        public static ApplicationJobs Instance => Lazy.Value;

        public int Value { get; set; }

        public void Work()
        {
            for (int index = 0; index < 5; index++)
            {
                Value += 1;
            }

            ValueChanged?.Invoke(Value);
        }

        /// <summary>
        /// Increment <see cref="Value"/> by increaseBy
        /// which defaults to one if no value is passed
        /// </summary>
        /// <param name="increaseBy"></param>
        public void IncrementValue(int increaseBy = 1)
        {
            Value += increaseBy;
            ValueChanged?.Invoke(Value);
        }

        /// <summary>
        /// This is needed when there are many things to
        /// reset
        /// </summary>
        public void Reset()
        {
            Value = 0;
            ValueChanged?.Invoke(Value);
        }

        private ApplicationJobs()
        {
            // TODO any initialization that may be needed
        }
    }
}