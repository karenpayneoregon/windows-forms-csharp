$SqlConnection = New-Object System.Data.SqlClient.SqlConnection
$SqlConnection.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True" 
$SqlCmd = New-Object System.Data.SqlClient.SqlCommand
$SqlCmd.CommandText = 'SELECT @@SERVERNAME AS ServerName'
$SqlCmd.Connection = $SqlConnection 
$SqlConnection.Open()
$rdr = $SqlCmd.ExecuteReader()
while($rdr.Read())
{
  $rdr["ServerName"].ToString()
}
$SqlConnection.Close()
Write-Host "Done"

