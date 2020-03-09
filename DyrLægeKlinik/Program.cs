using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DyrLægeKlinik
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.AnimalPet kæleDyr = new Model.AnimalPet(ConnectionClass.sqlConnection())
            {
                AnimalName = "DyreNavn - 12000",
                AnimalAge = 3,
                DyrRace = new Model.AnimalRace()
                {
                    Race = "Hund"
                },
                DyrKøn = new Model.AnimalSex()
                {
                    Køn = "HanKøn"
                },
                AnimalOwner = new Model.AnimalOwner()
                {
                    Name = "ThomasTest",
                    
                }
               
            };

            kæleDyr.Save(kæleDyr);
            //kæleDyr.Delete(kæleDyr);
            Console.ReadLine();
        }
    }
}
