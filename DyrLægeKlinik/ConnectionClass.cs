﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;

namespace DyrLægeKlinik
{
    class ConnectionClass
    {
        protected SqlConnection conn;
        //public static void Connection(SqlConnection connection, SqlCommand sqlCommand)
        //{
            
        //    connection.Open();
        //    sqlCommand.ExecuteNonQuery();
        //    connection.Close();
        //}
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
        public static void Insert(string tableName,ArrayList values,List<string> keys,SqlConnection connection)
        {
            string colums = string.Join(",", keys);
            string parammeters = "@" + string.Join(",@", keys);
            string query = "INSERT INTO " + tableName + " (" + colums + ")" +
            " VALUES " + "(" + parammeters + ")";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            for (int i = 0; i < keys.Count; i++)
            {
                sqlCommand.Parameters.Add(new SqlParameter("@" + keys[i], values[i]));
            }

            Console.WriteLine(query);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
   
    }
}
