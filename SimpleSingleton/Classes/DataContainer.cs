using System;

namespace SimpleSingleton.Classes
{
    public sealed class DataContainer
    {
        private static readonly Lazy<DataContainer> Lazy = new Lazy<DataContainer>(() => new DataContainer());
        public static DataContainer Instance => Lazy.Value;
        public int ValueToShare { get; set; }
    }
}