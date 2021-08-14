namespace GroupByWithCountMocked.Classes
{
    public enum ConnectionType
    {
        IP,
        COM
    }
    public class ConnectionData
    {
        public ConnectionType ConnectionType { get; set; }
        public string ComPort { get; set; }
        public string TcpPort { get; set; }
        public string ConnectionName { get; set; }
        

        public override string ToString() => ConnectionName;

    }
    
}
