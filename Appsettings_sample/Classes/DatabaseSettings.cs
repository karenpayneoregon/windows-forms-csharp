namespace Appsettings_sample.Classes
{
    public class DatabaseSettings
    {
        public string DatabaseServer { get; set; }
        public string Catalog { get; set; }
        public bool IntegratedSecurity { get; set; }
        public bool UsingLogging { get; set; }
        public int Timeout { get; set; }
        
        public string ConnectionString => 
            $"Data Source={DatabaseServer};" +
            $"Initial Catalog={Catalog};" +
            $"Integrated Security={IntegratedSecurity};" + 
            $"Connection Timeout={Timeout}";

        public override string ToString() => ConnectionString;

    }

}
