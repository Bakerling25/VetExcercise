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
                Navn = "Test - Test",
                Alder = 3,
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

            kæleDyr.Save();
            //kæleDyr.Delete(kæleDyr);
            Console.ReadLine();
        }
    }
}
