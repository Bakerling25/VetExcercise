using System;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Model.KæleDyr kæleDyr = new Model.KæleDyr(ConnectionClass.sqlConnection())
            {
                AnimalName = "Fiddo",
                AnimalAge = 3,
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
