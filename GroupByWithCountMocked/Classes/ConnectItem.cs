using System.Collections.Generic;

namespace GroupByWithCountMocked.Classes
{
    public class ConnectItem
    {
        public string Port { get; set; }
        public IEnumerable<string> Names { get; set; }
        public int Count { get; set; }
        public List<ConnectionData> List { get; set; }
    }
}