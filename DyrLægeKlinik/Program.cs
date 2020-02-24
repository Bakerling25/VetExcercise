using System;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "Vet",
                UserID = "ThomasTest",
                Password = "1234",
                DataSource = "localhost"
            };
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            Model.KæleDyr kæleDyr = new Model.KæleDyr(connection)
            {
                AnimalName = "Fiddo",
                AnimalAge = 12002,
                DyrRace = new Model.DyrRace()
                {
                    Race = "Hund"
                },
                DyrKøn = new Model.DyrKøn()
                {
                    Køn = "HanKøn"
                }
               
            };
            kæleDyr.Save();
            //kæleDyr.Delete();
            Console.ReadLine();
        }
    }
}
