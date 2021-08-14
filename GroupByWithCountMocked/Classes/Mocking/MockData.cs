using System;
using System.Collections.Generic;
using System.Data;

//using System.ComponentModel.DataAnnotations;

namespace GroupByWithCountMocked.Classes.Mocking
{
    public class MockData
    {
        
        public static List<ConnectionData> DatatypeList => new List<ConnectionData>
        {
            new()
            {
                ConnectionType = ConnectionType.COM,
                ComPort = "COM1",
                TcpPort = null,
                ConnectionName = "CONN1"
            },
            new()
            {
                ConnectionType = ConnectionType.COM,
                ComPort = "COM1",
                TcpPort = null,
                ConnectionName = "CONN2"
            },
            new()
            {
                ConnectionType = ConnectionType.COM,
                ComPort = "COM1",
                TcpPort = null,
                ConnectionName = "CONN5"
            },
            new()
            {
                ConnectionType = ConnectionType.COM,
                ComPort = "COM2",
                TcpPort = null,
                ConnectionName = "CONN3",
            },
            new()
            {
                ConnectionType = ConnectionType.IP,
                ComPort = null,
                TcpPort = "1234",
                ConnectionName = "CONN4"
            },
            new()
            {
                ConnectionType = ConnectionType.IP,
                ComPort = null,
                TcpPort = "1234",
                ConnectionName = "CONN5"
            },
            new()
            {
                ConnectionType = ConnectionType.IP,
                ComPort = null,
                TcpPort = "4321",
                ConnectionName = "CONN6"
            }
        };
    }
}