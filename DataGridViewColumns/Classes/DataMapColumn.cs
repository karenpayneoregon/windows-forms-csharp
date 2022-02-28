namespace DataGridViewColumns.Classes
{
    public class DataMapColumn
    {
        public int ConfigurationId { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() => Name;
    }
}