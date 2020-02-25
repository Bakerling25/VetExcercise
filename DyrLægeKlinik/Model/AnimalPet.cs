using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class AnimalPet
    {
        private int animalId;
        private string animalName;
        private int animalAge;
        private AnimalRace dyrRace;
        private AnimalSex dyrKøn;
        private SqlConnection conn;
        public AnimalPet(SqlConnection connection)
        {
            conn = connection;
        }
        public int AnimalId
        {
            get;
            set;
        }
        public string AnimalName
        {
            get;
            set;
        }
        public int AnimalAge
        {
            get;
            set;
        }
        public AnimalRace DyrRace
        {
            get;
            set;
        }
        public AnimalSex DyrKøn
        {
            get;
            set;
        }
        public void Save()
        {
            string query = "INSERT INTO AnimalPet (Navn, Alder) VALUES " + "('" + AnimalName + "'," + AnimalAge + ")";
            ConnectionClass.Connection(conn, query);
        }
        public void Delete()
        {
            string query = "Delete from AnimalPet Where Navn =" + "('" + AnimalName + "')";
            ConnectionClass.Connection(conn, query);
        }

    }
}
