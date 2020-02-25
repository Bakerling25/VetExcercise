using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DyrLægeKlinik.Model
{
    class KæleDyr
    {
        private int animalId;
        private string animalName;
        private int animalAge;
        private DyrRace dyrRace;
        private DyrKøn dyrKøn;
        private SqlConnection conn;
        public KæleDyr(SqlConnection connection)
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
        public DyrRace DyrRace
        {
            get;
            set;
        }
        public DyrKøn DyrKøn
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
