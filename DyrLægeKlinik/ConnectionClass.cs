using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class ConnectionClass
    {
        private SqlConnection conn;
        public static void Connection(SqlConnection connection, string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        public static SqlConnection sqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "Vet",
                UserID = "ThomasTest",
                Password = "1234",
                DataSource = "localhost"
            };
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
       
    }
}
