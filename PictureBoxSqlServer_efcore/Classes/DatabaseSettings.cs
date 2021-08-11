namespace PictureBoxSqlServer_efcore.Classes
{
    public class DatabaseSettings
    {
        public string DatabaseServer { get; set; }
        public string Catalog { get; set; }
        public bool IntegratedSecurity { get; set; }
        public bool UsingLogging { get; set; }
    }

}
