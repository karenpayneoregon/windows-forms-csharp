using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DataGridViewDataTableOracle.Classes
{

    /// <summary>
    /// VB.NET Code in -> OracleOperationsVisualBase.txt
    /// </summary>
    public class OracleOperations
    {
        public static string ConnectionString = "TODO;";

        /// <summary>
        /// Read a table
        /// </summary>
        /// <returns>
        /// <see cref="DataResults"/>
        /// Which could be replaced with a named value tuple
        /// </returns>
        public static async Task<DataResults> ReadAllAsync()
        {
            var dt = new DataTable();
            
            var results = new DataResults()
            {
                Success = true
            };
            
            return await Task.Run(async () =>
            {

                try
                {
                    using (var cn = new OracleConnection(ConnectionString))
                    {
                        using (var cmd = cn.CreateCommand())
                        {
                            cmd.CommandText = "TODO";
                            cmd.CommandType = CommandType.Text;
                            await cn.OpenAsync();
                            dt.Load(await cmd.ExecuteReaderAsync());
                        }
                    }

                    results.DataTable = dt;
                    return results;

                }
                catch (Exception ex)
                {
                    results.Exception = ex;
                    results.Success = false;
                    return results;
                }

            });
        }
    }
}
