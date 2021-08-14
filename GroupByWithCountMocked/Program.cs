using System;
using System.Collections.Generic;
using System.Linq;
using GroupByWithCountMocked.Classes;
using GroupByWithCountMocked.Classes.Mocking;

namespace GroupByWithCountMocked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GroupBy/Count/List (mocked)";
            
            IEnumerable<ConnectItem> result = MockData.DatatypeList
                .GroupBy(item => item.ConnectionType == ConnectionType.IP ? item.TcpPort : item.ComPort)
                .Where(groupedConnectionData => groupedConnectionData.Count() > 1)
                .Select(groupedConnectionData => new ConnectItem
                {
                    Port  = groupedConnectionData.Key,
                    Names = groupedConnectionData.Select(connectionData => connectionData.ConnectionName),
                    Count = groupedConnectionData.Count(), 
                    List  = groupedConnectionData.ToList()
                });


            foreach (ConnectItem dataItem in result)
            {
                Console.WriteLine($"{dataItem.Port} ({dataItem.Count})");
                List<ConnectionData> connectionDataList = dataItem.List;

                foreach (ConnectionData data in connectionDataList)
                {
                    Console.WriteLine($"\t{data.ConnectionName} {data.ConnectionType}");
                }
            }

            Console.ReadLine();
        }
    }
}
