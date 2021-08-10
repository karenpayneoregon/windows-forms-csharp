using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectorLibrary
{
    public sealed class SqlServerConnections
    {
        private static readonly Lazy<SqlServerConnections>
            Lazy = new Lazy<SqlServerConnections>(() => new SqlServerConnections());

        public static SqlServerConnections Instance => Lazy.Value;
        private readonly Hashtable _connections = new Hashtable();
        public string ConnectionString { get; set; }

        /// <summary>
        /// Reset an existing connection string
        /// </summary>
        /// <param name="connectionString">An existing connection string</param>
        public void Reset(string connectionString)
        {
            SqlConnection connection = null;

            try
            {
                connection = (SqlConnection)_connections[connectionString];
                connection.Dispose();
                connection = null;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Used to reset all known connections to null
        /// </summary>
        public void ResetAll()
        {
            foreach (var cn in _connections)
            {
                SqlConnection connection = null;

                try
                {
                    connection = (SqlConnection)cn;
                    connection.Dispose();
                    connection = null;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        public SqlConnection Connection()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new NullReferenceException("Connection string can not be empty");
            }
            
            return Connection(ConnectionString);
        }
        /// <summary>
        /// Returns an open connection for connection string
        /// </summary>
        /// <param name="connectionString">Valid connection string</param>
        /// <returns>Connection</returns>
        public SqlConnection Connection(string connectionString)
        {
            SqlConnection connection = null;
            var bNeedAdd = false;

            try
            {
                connection = (SqlConnection)_connections[connectionString];
            }
            catch (Exception)
            {
                // ignored
            }

            if (connection == null)
            {
                bNeedAdd = true;
            }

            if (connection == null || connection.State == ConnectionState.Broken || connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection?.Dispose();
                    connection = null;
                }
                catch (Exception)
                {
                    // ignored
                }

                connection = new SqlConnection();
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            }

            if (bNeedAdd)
            {
                _connections.Add(connectionString, connection);
            }

            return connection;
        }

    }
}
