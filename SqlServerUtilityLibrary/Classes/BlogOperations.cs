
using System;
using System.Data.SqlClient;

namespace SqlServerUtilityLibrary.Classes
{
    /// <summary>
    /// Select *  from sysservers  where srvproduct='SQL Server'; Select * from sysdatabases
    /// C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\Backup
    /// https://docs.microsoft.com/en-us/sql/relational-databases/backup-restore/quickstart-backup-restore-database?view=sql-server-ver15
    /// </summary>
    public class BlogOperations
    {
        public static string MasterConnection =>
            "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        public static bool RestoreBlogDatabase()
        {
            var restoreStatement = 
                "ALTER DATABASE [DatabaseFirst.Blogging] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                "RESTORE DATABASE [DatabaseFirst.Blogging] FROM  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.SQLEXPRESS\\MSSQL\\Backup\\" + 
                    "DatabaseFirst.Blogging.bak' WITH REPLACE; " +
                "ALTER DATABASE [DatabaseFirst.Blogging] SET MULTI_USER;";

            using var cn = new SqlConnection { ConnectionString = MasterConnection };
            using var cmd = new SqlCommand() { Connection = cn, CommandText = restoreStatement };
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
