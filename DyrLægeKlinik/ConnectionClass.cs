using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class ConnectionClass
    {
        protected SqlConnection conn;
        public static void Connection(SqlConnection connection, SqlCommand sqlCommand)
        {
            
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
        public void Save(Model.AnimalPet animalPet)
        {
            string insert = "Insert into AnimalPet (Navn,Alder) Values (@AnimalName,@AnimalAge)";
            SqlCommand sqlCommand = new SqlCommand(insert, conn);
            sqlCommand.Parameters.Add(new SqlParameter("@AnimalName", animalPet.AnimalName));
            sqlCommand.Parameters.Add(new SqlParameter("@AnimalAge", animalPet.AnimalAge));
            Connection(conn, sqlCommand);
        }
        public void Update(Model.AnimalPet animalPet)
        {
            
        }
        public void view()
        {

        }
        public void Delete(Model.AnimalPet animalPet)
        {
            string delete = "Delete from AnimalPet Where Navn = @animalName";
            SqlCommand sqlCommand = new SqlCommand(delete,conn);
            sqlCommand.Parameters.Add(new SqlParameter("@animalName", animalPet.AnimalName));
            Connection(conn, sqlCommand);
        }
        
    }
}
